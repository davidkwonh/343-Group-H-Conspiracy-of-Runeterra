using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ziggs : ChampionCard
{
    // Start is called before the first frame update
    void Start()
    {
        setCard(12);
        changeSprite(champions[getCardID() - 1]); // Subtract one because sprites start at 0 but card ID's start at 1.
        power = 1;
        transferPower = 0;
        resistance = 4;
        income = 1;
        gold = 0;
        alignments.Add("Monster");
        alignments.Add("Yordle");
    }

    /*// Update is called once per frame
    void Update()
    {
        
    }*/
}