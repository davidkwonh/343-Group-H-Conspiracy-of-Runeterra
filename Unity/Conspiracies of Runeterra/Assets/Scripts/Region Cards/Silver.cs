﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Silver : RegionCard
{
    // Start is called before the first frame update
    void Start()
    {
        setCard(3);
        changeSprite(myParent.regions[getCardID() - 1]); // Subtract one because sprites start at 0 but card ID's start at 1.
        spawnArrows();
        power = 8;
        transferPower = 8;
        income = 8;
        gold = 8;
    }
}