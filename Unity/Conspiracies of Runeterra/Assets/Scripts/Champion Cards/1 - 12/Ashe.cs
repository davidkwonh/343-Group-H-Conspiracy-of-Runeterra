using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ashe : ChampionCard
{
    // Private Variables
    ChampionCard myParent;

    // Start is called before the first frame update
    void Start()
    {
        setCard(7);
        changeSprite(myParent.champions[getCardID() - 1]); // Subtract one because sprites start at 0 but card ID's start at 1.
        power = 6;
        transferPower = 0;
        resistance = 5;
        income = 3;
        gold = 0;
        alignments.Add("Freljordian");
    }

    /*// Update is called once per frame
    void Update()
    {
        
    }*/

    public void setParent(ChampionCard parent)
    {
        myParent = parent;
    }
}