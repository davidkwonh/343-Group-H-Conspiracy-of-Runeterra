﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cassiopeia : ChampionCard
{
    // Start is called before the first frame update
    void Start()
    {
        setCard(3);
        changeSprite(myParent.champions[getCardID() - 1]); // Subtract one because sprites start at 0 but card ID's start at 1.
        power = 0;
        transferPower = 0;
        resistance = 3;
        income = 1;
        gold = 0;
        alignments.Add("Noxian");
        alignments.Add("Freljordian");
    }
}