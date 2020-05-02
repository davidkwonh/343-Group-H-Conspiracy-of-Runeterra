using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anivia : ChampionCard
{
    // Start is called before the first frame update
    void Start()
    {
        setCard(6);
        changeSprite(champions[getCardID() - 1]); // Subtract one because sprites start at 0 but card ID's start at 1.
        power = 5;
        transferPower = 0;
        resistance = 4;
        income = 5;
        gold = 0;
        alignments.Add("Freljordian");
        alignments.Add("Shuriman");
        alignments.Add("Demacian");
    }

    // Unsure if needed yet.
    /*// Update is called once per frame
    void Update()
    {
        
    }*/
}
