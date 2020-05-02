using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Galio : ChampionCard
{
    // Start is called before the first frame update
    void Start()
    {
        setCard(9);
        changeSprite(champions[getCardID() - 1]); // Subtract one because sprites start at 0 but card ID's start at 1.
        power = 6;
        transferPower = 4;
        resistance = 5;
        income = 0;
        gold = 0;
        alignments.Add("Demacian");
        alignments.Add("Zaunist");
    }

    /*// Update is called once per frame
    void Update()
    {
        
    }*/
}