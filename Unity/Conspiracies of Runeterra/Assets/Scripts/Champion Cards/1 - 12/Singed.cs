using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singed : ChampionCard
{
    // Start is called before the first frame update
    void Start()
    {
        setCard(1);
        changeSprite(myParent.champions[getCardID() - 1]); // Subtract one because sprites start at 0 but card ID's start at 1.
        power = 1;
        transferPower = 0;
        resistance = 5;
        income = 1;
        gold = 0;
        alignments.Add("Zaunist");
        alignments.Add("Shuriman");
    }

    /*// Update is called once per frame
    void Update()
    {
        
    }*/
}