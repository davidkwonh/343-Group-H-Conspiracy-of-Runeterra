using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenger : RegionCard
{
    // Start is called before the first frame update
    void Start()
    {
        setCard(8);
        changeSprite(myParent.regions[getCardID() - 1]); // Subtract one because sprites start at 0 but card ID's start at 1.
        power = 6;
        transferPower = 6;
        income = 8;
        gold = 8;
    }
    /*
    // Update is called once per frame
    void Update()
    {
        
    }*/
}