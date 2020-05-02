using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kayn : ChampionCard
{
    // Start is called before the first frame update
    void Start()
    {
        setCard(8);
        changeSprite(champions[getCardID() - 1]); // Subtract one because sprites start at 0 but card ID's start at 1.
        power = 3;
        transferPower = 0;
        resistance = 2;
        income = 3;
        gold = 0;
        alignments.Add("Ionian");
    }

    /*// Update is called once per frame
    void Update()
    {
        
    }*/

    // Special Ability
    // Treat this champion as Demacian when it attempts to control a Demacian champion.
}