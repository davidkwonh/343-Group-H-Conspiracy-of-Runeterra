using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sivir : ChampionCard
{
    // Start is called before the first frame update
    void Start()
    {
        setCard(11);
        changeSprite(myParent.champions[getCardID() - 1]); // Subtract one because sprites start at 0 but card ID's start at 1.
        power = 1;
        transferPower = 0;
        resistance = 1;
        income = 2;
        gold = 0;
        alignments.Add("Shuriman");
        alignments.Add("Zaunist");
    }

    /*// Update is called once per frame
    void Update()
    {
        
    }*/
}