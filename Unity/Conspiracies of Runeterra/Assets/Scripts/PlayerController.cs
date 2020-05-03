using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Static variable to allow other objects to interact with this one.
    public static PlayerController playerControl = null;

    //
    public GameObject camera;
    public GameObject player;
    public List<GameObject> myPlayers;

    // Private Variables
    GameObject currentPlayer;
    GameObject nextPlayer;
    bool activeTurn = false;

    //
    private void Awake()
    {
        if (playerControl == null)
            playerControl = this;
        else if (playerControl != this)
            Destroy(gameObject);

        populatePlayers();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("return"))
        {
            if (activeTurn == false)
                endTurn();
        }
    }

    //
    private void populatePlayers()
    {
        myPlayers = new List<GameObject>();
        GameObject instance;

        instance = Instantiate(player, new Vector3(0, -10, 0), Quaternion.identity) as GameObject;
        myPlayers.Add(instance);

        instance = Instantiate(player, new Vector3(0, 10, 0), Quaternion.identity) as GameObject;
        myPlayers.Add(instance);
    }
    public void rollForFirst()
    {
        int randomIndex = Random.Range(0, myPlayers.Count);
        myPlayers[randomIndex].GetComponent<Player>().setFirstPlayer();
        currentPlayer = myPlayers[randomIndex];
    }
    public IEnumerator sequenceOfPlay()
    {
        activeTurn = true;
        yield return new WaitForSeconds(1f);

        // Determine Next Player.
        if (myPlayers.IndexOf(currentPlayer) + 1 == myPlayers.Count)
            nextPlayer = myPlayers[0];
        else
            nextPlayer = myPlayers[myPlayers.IndexOf(currentPlayer) + 1];

        // Collect Income
        currentPlayer.GetComponent<Player>().collectIncome();
        // Draw a card.

        // Take 2 Actions.

        // Take any free actions.

        // Transfer Money.

        // Take special-power actions.

        // Add targets.
        while (UncontrolledArea.uncontrolled.myHolders.Count < 2)
        {
            UncontrolledArea.uncontrolled.addHolder();
            Deck.deck.drawCard();
        }
        // End Turn.
        activeTurn = false;
    }

    //
    private void endTurn()
    {
        // Check if anyone won.

        // Go to next player.
        camera.transform.Rotate(Vector3.forward * 180);
        currentPlayer = nextPlayer;
        StartCoroutine(sequenceOfPlay());
    }
}