using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Public Variables
    public GameObject holder;

    // Private Variables
    private GameObject myRegion;
    private List<GameObject> myChamps = new List<GameObject>();
    private List<GameObject> myChampHolders = new List<GameObject>();
    private List<GameObject> mySpellHolders = new List<GameObject>();
    private bool isFirst;

    // Start is called before the first frame update
    void Start()
    {
        isFirst = false;
        spawnHolders();
    }

    // Set region to given card.
    public void setRegion(GameObject card)
    {
        myRegion = card;
        myRegion.transform.position = transform.position;
        if (this == PlayerController.playerControl.myPlayers[1].GetComponent<Player>())
            myRegion.transform.Rotate(Vector3.forward * 180);
    }
    public GameObject getRegion()
    {
        return myRegion;
    }

    // Set as first player.
    public void setFirstPlayer()
    {
        isFirst = true;
    }

    // Collect income for each controlled card.
    public void collectIncome()
    {
        myRegion.GetComponent<RegionCard>().getChild().gainIncome();
        for (int i = 0; i < myChamps.Count; i++)
            myChamps[i].GetComponent<ChampionCard>().getChild().gainIncome();
    }
    
    // Draw the top card of the deck.
    public void drawCard()
    {
        GameObject card = Deck.deck.drawCard();
        if (card.GetComponent<SpellCard>() != null)
        {
            card.GetComponent<SpriteRenderer>().enabled = true;
            if (transform.rotation != Quaternion.identity)
                card.transform.Rotate(Vector3.forward * 180);
            if (mySpellHolders[0].GetComponent<CardHolder>().hasCard() == false)
                mySpellHolders[0].GetComponent<CardHolder>().holdCard(card);
            else
            {
                GameObject instance;
                if (transform.rotation == Quaternion.identity)
                    instance = Instantiate(holder, mySpellHolders[mySpellHolders.Count - 1].transform.position + new Vector3(0, -10, 0), Quaternion.identity) as GameObject;
                else
                    instance = Instantiate(holder, mySpellHolders[mySpellHolders.Count - 1].transform.position + new Vector3(0, 10, 0), Quaternion.identity) as GameObject;
                mySpellHolders.Add(instance);
                instance.GetComponent<CardHolder>().holdCard(card);
            }
        }
        else
        {
            UncontrolledArea.uncontrolled.addHolder();
            int lastHolder = UncontrolledArea.uncontrolled.myHolders.Count - 1;
            card.GetComponent<SpriteRenderer>().enabled = true;
            if (transform.rotation != Quaternion.identity)
                card.transform.Rotate(Vector3.forward * 180);
            UncontrolledArea.uncontrolled.myHolders[lastHolder].GetComponent<CardHolder>().holdCard(card);
        }
    }

    // Begin Attack.
    public void attack()
    {
        if (myRegion.GetComponent<RegionCard>().getChild().getAttack())
        {
            UncontrolledArea.uncontrolled.spawnSelectBoxes();
        }
    }
    // Attack given card.
    public IEnumerator attackToControl(GameObject card)
    {
        int originalPower = myRegion.GetComponent<RegionCard>().getChild().getPower();
        while (PlayerController.playerControl.addingGold)
        {
            yield return null;
        }

        int targetResistance = card.GetComponent<ChampionCard>().getChild().getResistance();
        int attackerPower = myRegion.GetComponent<RegionCard>().getChild().getPower();
        int attackGoal = attackerPower - targetResistance;
        int randomRoll = Random.Range(2, 13);
        print(randomRoll + "<roll goal>" + attackGoal);

        if (randomRoll <= attackGoal && randomRoll < 11)
        {
            // Success attack
            GameObject cardHolder = myRegion.GetComponent<RegionCard>().getChild().getOpenArrow();
            cardHolder.GetComponent<CardHolder>().holdCard(card);
            myChamps.Add(card);
            myRegion.GetComponent<RegionCard>().getChild().fillArrow();

            // Update Uncontrolled Area
            UncontrolledArea.uncontrolled.updateCards();
        }
        else
        {
            // Fail
            UncontrolledArea.uncontrolled.updateCards();
            UncontrolledArea.uncontrolled.addHolder();
            int lastHolder = UncontrolledArea.uncontrolled.myHolders.Count - 1;
            UncontrolledArea.uncontrolled.myHolders[lastHolder].GetComponent<CardHolder>().holdCard(card);
        }

        PlayerController.playerControl.attacked = true;
        myRegion.GetComponent<RegionCard>().getChild().resetPower(originalPower);
    }

    // Create card holders.
    void spawnHolders()
    {
        GameObject instance;

        /*instance = Instantiate(holder, transform.position + new Vector3(0, 10, 0), Quaternion.identity) as GameObject;
        myChampHolders.Add(instance);*/

        // Spell Holder
        if (transform.rotation == Quaternion.identity)
            instance = Instantiate(holder, transform.position + new Vector3(15, -10, 0), Quaternion.identity) as GameObject;
        else
            instance = Instantiate(holder, transform.position + new Vector3(15, 10, 0), Quaternion.identity) as GameObject;
        mySpellHolders.Add(instance);
    }

    // Check for win conditions.
    public bool checkWin()
    {
        // If (# players < 3)
        // Win by controlling 13 champions.

        // Win when Region has 4 champions attached.
        if (myRegion.GetComponent<RegionCard>().getChild().getOpenArrow() == null)
            return true;

        return false;
    }
}