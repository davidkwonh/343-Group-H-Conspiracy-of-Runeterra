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
        // Region Cards
        populateRegions();
        // Champion Cards
        populateChampions();
        // Spell Cards
        populateSpells();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Pass/Get Region Cards
    // Pass/Get Champion Cards
    // Pass/Get Spell Cards
    void populateRegions()
    {
        regionCards = new List<GameObject>();
        GameObject instance;

        // 1 Iron
        instance = Instantiate(regionCard, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        instance.AddComponent<Iron>();
        instance.GetComponent<Iron>().setParent(instance.GetComponent<RegionCard>());
        regionCards.Add(instance);
        // 2 Bronze
        instance = Instantiate(regionCard, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        instance.AddComponent<Bronze>();
        instance.GetComponent<Bronze>().setParent(instance.GetComponent<RegionCard>());
        regionCards.Add(instance);
        // 3 Silver
        instance = Instantiate(regionCard, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        instance.AddComponent<Silver>();
        instance.GetComponent<Silver>().setParent(instance.GetComponent<RegionCard>());
        regionCards.Add(instance);
        // 4 Gold
        instance = Instantiate(regionCard, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        instance.AddComponent<Gold>();
        instance.GetComponent<Gold>().setParent(instance.GetComponent<RegionCard>());
        regionCards.Add(instance);
        // 5 Platinum
        instance = Instantiate(regionCard, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        instance.AddComponent<Platinum>();
        instance.GetComponent<Platinum>().setParent(instance.GetComponent<RegionCard>());
        regionCards.Add(instance);
        // 6 Diamond
        instance = Instantiate(regionCard, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        instance.AddComponent<Diamond>();
        instance.GetComponent<Diamond>().setParent(instance.GetComponent<RegionCard>());
        regionCards.Add(instance);
        // 7 Master
        instance = Instantiate(regionCard, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        instance.AddComponent<Master>();
        instance.GetComponent<Master>().setParent(instance.GetComponent<RegionCard>());
        regionCards.Add(instance);
        // 8 Challenger
        instance = Instantiate(regionCard, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        instance.AddComponent<Challenger>();
        instance.GetComponent<Challenger>().setParent(instance.GetComponent<RegionCard>());
        regionCards.Add(instance);
    }
    void populateChampions()
    {
        championCards = new List<GameObject>();
        GameObject instance;

        // 01 Singed
        instance = Instantiate(champCard, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        instance.AddComponent<Singed>();
        instance.GetComponent<Singed>().setParent(instance.GetComponent<ChampionCard>());
        championCards.Add(instance);
        // 02 Sejuani
        instance = Instantiate(champCard, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        instance.AddComponent<Sejuani>();
        instance.GetComponent<Sejuani>().setParent(instance.GetComponent<ChampionCard>());
        championCards.Add(instance);
        // 03 Cassiopeia
        instance = Instantiate(champCard, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        instance.AddComponent<Cassiopeia>();
        instance.GetComponent<Cassiopeia>().setParent(instance.GetComponent<ChampionCard>());
        championCards.Add(instance);
        // 04 Gnar
        instance = Instantiate(champCard, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        instance.AddComponent<Gnar>();
        instance.GetComponent<Gnar>().setParent(instance.GetComponent<ChampionCard>());
        championCards.Add(instance);
        // 05 Veigar
        instance = Instantiate(champCard, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        instance.AddComponent<Veigar>();
        instance.GetComponent<Veigar>().setParent(instance.GetComponent<ChampionCard>());
        championCards.Add(instance);
        // 06 Anivia
        instance = Instantiate(champCard, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        instance.AddComponent<Anivia>();
        instance.GetComponent<Anivia>().setParent(instance.GetComponent<ChampionCard>());
        championCards.Add(instance);
        // 07 Ashe
        instance = Instantiate(champCard, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        instance.AddComponent<Ashe>();
        instance.GetComponent<Ashe>().setParent(instance.GetComponent<ChampionCard>());
        championCards.Add(instance);
        // 08 Kayn
        instance = Instantiate(champCard, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        instance.AddComponent<Kayn>();
        instance.GetComponent<Kayn>().setParent(instance.GetComponent<ChampionCard>());
        championCards.Add(instance);
        // 09 Galio
        instance = Instantiate(champCard, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        instance.AddComponent<Galio>();
        instance.GetComponent<Galio>().setParent(instance.GetComponent<ChampionCard>());
        championCards.Add(instance);
        // 10 Dr. Mundo
        instance = Instantiate(champCard, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        instance.AddComponent<Mundo>();
        instance.GetComponent<Mundo>().setParent(instance.GetComponent<ChampionCard>());
        championCards.Add(instance);
        // 11 Sivir
        instance = Instantiate(champCard, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        instance.AddComponent<Sivir>();
        instance.GetComponent<Sivir>().setParent(instance.GetComponent<ChampionCard>());
        championCards.Add(instance);
        // 12 Ziggs
        instance = Instantiate(champCard, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        instance.AddComponent<Ziggs>();
        instance.GetComponent<Ziggs>().setParent(instance.GetComponent<ChampionCard>());
        championCards.Add(instance);
    }
    void populateSpells()
    {
        spellCards = new List<GameObject>();
        GameObject instance;

        // 01 Ignite
        instance = Instantiate(spellCard, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        //instance.AddComponent<Ignite>();
        //instance.GetComponent<Ignite>().setParent(instance.GetComponent<SpellCard>());
        spellCards.Add(instance);
    }
}
