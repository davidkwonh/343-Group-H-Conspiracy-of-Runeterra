using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sejuani : ChampionCard
{
    // Start is called before the first frame update
    void Start()
    {
        setCard(2);
        changeSprite(champions[getCardID() - 1]); // Subtract one because sprites start at 0 but card ID's start at 1.
        power = 2;
        transferPower = 0;
        resistance = 5;
        income = 1;
        gold = 0;
        alignments.Add("Freljordian");
    }

    /*// Update is called once per frame
    void Update()
    {
        
    }*/

    // Special Ability
    // +2 on any attempt to destroy Trundle (ID 55).
}