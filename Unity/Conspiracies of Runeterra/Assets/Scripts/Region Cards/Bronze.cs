using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bronze : RegionCard
{
    // Start is called before the first frame update
    void Start()
    {
        setCard(2);
        changeSprite(myParent.regions[getCardID() - 1]); // Subtract one because sprites start at 0 but card ID's start at 1.
        power = 8;
        transferPower = 8;
        income = 9;
        gold = 9;
    }
    /*
    // Update is called once per frame
    void Update()
    {
        
    }*/
}