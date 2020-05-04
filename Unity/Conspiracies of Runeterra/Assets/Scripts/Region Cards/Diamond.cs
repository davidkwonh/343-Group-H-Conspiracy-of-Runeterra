using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : RegionCard
{
    // Start is called before the first frame update
    void Start()
    {
        setCard(6);
        changeSprite(myParent.regions[getCardID() - 1]); // Subtract one because sprites start at 0 but card ID's start at 1.
        spawnArrows();
        power = 9;
        transferPower = 9;
        income = 7;
        gold = 7;
    }
}