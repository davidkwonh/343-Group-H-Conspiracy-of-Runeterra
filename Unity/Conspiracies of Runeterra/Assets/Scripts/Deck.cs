using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    // Private Variables
    // Vector of Region Cards
    // Vector of Champion Cards
    public GameObject card;
    // Vector of Spell Cards

    // Start is called before the first frame update
    void Start()
    {
        // Region Cards
        // Loop to create 8 Region cards.
        // Champion Cards
        // Loop to create 83 Champion cards.

        // Champion Card Tests
        GameObject instance;

        instance = Instantiate(card, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        instance = Instantiate(card, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        instance.AddComponent<Ashe>();
        instance.GetComponent<Ashe>().setParent(instance.GetComponent<ChampionCard>());
        //instance.AddComponent<Ashe>();
        /*for (int i = 0; i < 12; i++)
        {
            
        }*/

        // Spell Cards
        // Loop to create 15 Spell cards.
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Pass/Get Region Cards
    // Pass/Get Champion Cards
    // Pass/Get Spell Cards
}
