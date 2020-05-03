using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    // Public Variables
    public GameObject champCard;
    public GameObject regionCard;
    public GameObject spellCard;

    // Private Variables
    private List<GameObject> regionCards;
    private List<GameObject> championCards;
    private List<GameObject> spellCards;

    // Start is called before the first frame update
    void Start()
    {
        // Create Region Cards
        populateRegions();
        // Create Champion Cards
        populateChampions();
        // Create Spell Cards
        populateSpells();

        // Shuffle Regions & Champions
        randomizeList(regionCards);
        randomizeList(championCards);

        // Assign Region Cards
        for (int i = 0; i < 2; i++)
        {
            PlayerController.playerControl.myPlayers[i].GetComponent<Player>().setRegion(regionCards[i]);
            regionCards.RemoveAt(i);
        }

        // Remove remaining Region cards.
        while (regionCards.Count > 0)
        {
            Destroy(regionCards[0]);
            regionCards.RemoveAt(0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Pass/Get Region Cards
    // Pass/Get Champion Cards
    // Pass/Get Spell Cards
    void randomizeList(List<GameObject> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            GameObject temp = list[i];
            int randomIndex = Random.Range(i, list.Count);
            list[i] = list[randomIndex];
            list[randomIndex] = temp;
        }
    }
    void populateRegions()
    {
        regionCards = new List<GameObject>();
        GameObject instance;
        
        // 1 Iron
        instance = Instantiate(regionCard, transform.position, Quaternion.identity) as GameObject;
        instance.AddComponent<Iron>();
        instance.GetComponent<Iron>().setParent(instance.GetComponent<RegionCard>());
        regionCards.Add(instance);
        // 2 Bronze
        instance = Instantiate(regionCard, transform.position, Quaternion.identity) as GameObject;
        instance.AddComponent<Bronze>();
        instance.GetComponent<Bronze>().setParent(instance.GetComponent<RegionCard>());
        regionCards.Add(instance);
        // 3 Silver
        instance = Instantiate(regionCard, transform.position, Quaternion.identity) as GameObject;
        instance.AddComponent<Silver>();
        instance.GetComponent<Silver>().setParent(instance.GetComponent<RegionCard>());
        regionCards.Add(instance);
        // 4 Gold
        instance = Instantiate(regionCard, transform.position, Quaternion.identity) as GameObject;
        instance.AddComponent<Gold>();
        instance.GetComponent<Gold>().setParent(instance.GetComponent<RegionCard>());
        regionCards.Add(instance);
        // 5 Platinum
        instance = Instantiate(regionCard, transform.position, Quaternion.identity) as GameObject;
        instance.AddComponent<Platinum>();
        instance.GetComponent<Platinum>().setParent(instance.GetComponent<RegionCard>());
        regionCards.Add(instance);
        // 6 Diamond
        instance = Instantiate(regionCard, transform.position, Quaternion.identity) as GameObject;
        instance.AddComponent<Diamond>();
        instance.GetComponent<Diamond>().setParent(instance.GetComponent<RegionCard>());
        regionCards.Add(instance);
        // 7 Master
        instance = Instantiate(regionCard, transform.position, Quaternion.identity) as GameObject;
        instance.AddComponent<Master>();
        instance.GetComponent<Master>().setParent(instance.GetComponent<RegionCard>());
        regionCards.Add(instance);
        // 8 Challenger
        instance = Instantiate(regionCard, transform.position, Quaternion.identity) as GameObject;
        instance.AddComponent<Challenger>();
        instance.GetComponent<Challenger>().setParent(instance.GetComponent<RegionCard>());
        regionCards.Add(instance);
    }
    void populateChampions()
    {
        championCards = new List<GameObject>();
        GameObject instance;

        // 01 Singed
        instance = Instantiate(champCard, transform.position, Quaternion.identity) as GameObject;
        instance.AddComponent<Singed>();
        instance.GetComponent<Singed>().setParent(instance.GetComponent<ChampionCard>());
        championCards.Add(instance);
        // 02 Sejuani
        instance = Instantiate(champCard, transform.position, Quaternion.identity) as GameObject;
        instance.AddComponent<Sejuani>();
        instance.GetComponent<Sejuani>().setParent(instance.GetComponent<ChampionCard>());
        championCards.Add(instance);
        // 03 Cassiopeia
        instance = Instantiate(champCard, transform.position, Quaternion.identity) as GameObject;
        instance.AddComponent<Cassiopeia>();
        instance.GetComponent<Cassiopeia>().setParent(instance.GetComponent<ChampionCard>());
        championCards.Add(instance);
        // 04 Gnar
        instance = Instantiate(champCard, transform.position, Quaternion.identity) as GameObject;
        instance.AddComponent<Gnar>();
        instance.GetComponent<Gnar>().setParent(instance.GetComponent<ChampionCard>());
        championCards.Add(instance);
        // 05 Veigar
        instance = Instantiate(champCard, transform.position, Quaternion.identity) as GameObject;
        instance.AddComponent<Veigar>();
        instance.GetComponent<Veigar>().setParent(instance.GetComponent<ChampionCard>());
        championCards.Add(instance);
        // 06 Anivia
        instance = Instantiate(champCard, transform.position, Quaternion.identity) as GameObject;
        instance.AddComponent<Anivia>();
        instance.GetComponent<Anivia>().setParent(instance.GetComponent<ChampionCard>());
        championCards.Add(instance);
        // 07 Ashe
        instance = Instantiate(champCard, transform.position, Quaternion.identity) as GameObject;
        instance.AddComponent<Ashe>();
        instance.GetComponent<Ashe>().setParent(instance.GetComponent<ChampionCard>());
        championCards.Add(instance);
        // 08 Kayn
        instance = Instantiate(champCard, transform.position, Quaternion.identity) as GameObject;
        instance.AddComponent<Kayn>();
        instance.GetComponent<Kayn>().setParent(instance.GetComponent<ChampionCard>());
        championCards.Add(instance);
        // 09 Galio
        instance = Instantiate(champCard, transform.position, Quaternion.identity) as GameObject;
        instance.AddComponent<Galio>();
        instance.GetComponent<Galio>().setParent(instance.GetComponent<ChampionCard>());
        championCards.Add(instance);
        // 10 Dr. Mundo
        instance = Instantiate(champCard, transform.position, Quaternion.identity) as GameObject;
        instance.AddComponent<Mundo>();
        instance.GetComponent<Mundo>().setParent(instance.GetComponent<ChampionCard>());
        championCards.Add(instance);
        // 11 Sivir
        instance = Instantiate(champCard, transform.position, Quaternion.identity) as GameObject;
        instance.AddComponent<Sivir>();
        instance.GetComponent<Sivir>().setParent(instance.GetComponent<ChampionCard>());
        championCards.Add(instance);
        // 12 Ziggs
        instance = Instantiate(champCard, transform.position, Quaternion.identity) as GameObject;
        instance.AddComponent<Ziggs>();
        instance.GetComponent<Ziggs>().setParent(instance.GetComponent<ChampionCard>());
        championCards.Add(instance);
    }
    void populateSpells()
    {
        spellCards = new List<GameObject>();
        GameObject instance;

        // 01 Ignite
        instance = Instantiate(spellCard, transform.position, Quaternion.identity) as GameObject;
        instance.AddComponent<Ignite>();
        instance.GetComponent<Ignite>().setParent(instance.GetComponent<SpellCard>());
        spellCards.Add(instance);
        // 02 Smite
        instance = Instantiate(spellCard, transform.position, Quaternion.identity) as GameObject;
        instance.AddComponent<Smite>();
        instance.GetComponent<Smite>().setParent(instance.GetComponent<SpellCard>());
        spellCards.Add(instance);
        // 03 Clarity
        instance = Instantiate(spellCard, transform.position, Quaternion.identity) as GameObject;
        instance.AddComponent<Clarity>();
        instance.GetComponent<Clarity>().setParent(instance.GetComponent<SpellCard>());
        spellCards.Add(instance);
        // 04 Cleanse
        instance = Instantiate(spellCard, transform.position, Quaternion.identity) as GameObject;
        instance.AddComponent<Cleanse>();
        instance.GetComponent<Cleanse>().setParent(instance.GetComponent<SpellCard>());
        spellCards.Add(instance);
        // 05 Ghost
        instance = Instantiate(spellCard, transform.position, Quaternion.identity) as GameObject;
        instance.AddComponent<Ghost>();
        instance.GetComponent<Ghost>().setParent(instance.GetComponent<SpellCard>());
        spellCards.Add(instance);
        // 06 Heal
        instance = Instantiate(spellCard, transform.position, Quaternion.identity) as GameObject;
        instance.AddComponent<Heal>();
        instance.GetComponent<Heal>().setParent(instance.GetComponent<SpellCard>());
        spellCards.Add(instance);
        // 07 Barrier
        instance = Instantiate(spellCard, transform.position, Quaternion.identity) as GameObject;
        instance.AddComponent<Barrier>();
        instance.GetComponent<Barrier>().setParent(instance.GetComponent<SpellCard>());
        spellCards.Add(instance);
        // 08 Exhaust
        instance = Instantiate(spellCard, transform.position, Quaternion.identity) as GameObject;
        instance.AddComponent<Exhaust>();
        instance.GetComponent<Exhaust>().setParent(instance.GetComponent<SpellCard>());
        spellCards.Add(instance);
        // 09 Mark & Dash
        instance = Instantiate(spellCard, transform.position, Quaternion.identity) as GameObject;
        instance.AddComponent<MarkDash>();
        instance.GetComponent<MarkDash>().setParent(instance.GetComponent<SpellCard>());
        spellCards.Add(instance);
        // 10 Teleport
        instance = Instantiate(spellCard, transform.position, Quaternion.identity) as GameObject;
        instance.AddComponent<Teleport>();
        instance.GetComponent<Teleport>().setParent(instance.GetComponent<SpellCard>());
        spellCards.Add(instance);
        // 11 Flash
        instance = Instantiate(spellCard, transform.position, Quaternion.identity) as GameObject;
        instance.AddComponent<Flash>();
        instance.GetComponent<Flash>().setParent(instance.GetComponent<SpellCard>());
        spellCards.Add(instance);
    }
}
