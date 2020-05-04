using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iron : RegionCard
{
    // Start is called before the first frame update
    void Start()
    {
        setCard(1);
        changeSprite(myParent.regions[getCardID() - 1]); // Subtract one because sprites start at 0 but card ID's start at 1.
        power = 10;
        transferPower = 10;
        income = 9;
        gold = 9;

        openArrowUp = true;
        openArrowDown = true;
        openArrowLeft = true;
        openArrowRight = true;
    }
    /*
    // Update is called once per frame
    void Update()
    {
        
    }*/
}