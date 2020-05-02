using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mundo : ChampionCard
{
    // Start is called before the first frame update
    void Start()
    {
        setCard(10);
        changeSprite(champions[getCardID() - 1]); // Subtract one because sprites start at 0 but card ID's start at 1.
        power = 6;
        transferPower = 2;
        resistance = 6;
        income = 1;
        gold = 0;
        alignments.Add("Zaunist");
        alignments.Add("Ionain");
        alignments.Add("Void");
    }

    /*// Update is called once per frame
    void Update()
    {
        
    }*/

    // Special Ability
    // +3 on any attempt to destroy any champion.
}