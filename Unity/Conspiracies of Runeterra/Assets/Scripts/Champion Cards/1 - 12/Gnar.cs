using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gnar : ChampionCard
{
    // Start is called before the first frame update
    void Start()
    {
        setCard(4);
        changeSprite(myParent.champions[getCardID() - 1]); // Subtract one because sprites start at 0 but card ID's start at 1.
        power = 4;
        transferPower = 3;
        resistance = 6;
        income = 3;
        gold = 0;
        alignments.Add("Freljordian");
        alignments.Add("Yordle");
    }

    /*// Update is called once per frame
    void Update()
    {
        
    }*/
}