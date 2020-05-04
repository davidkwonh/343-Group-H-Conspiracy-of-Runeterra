using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Master : RegionCard
{
    // Start is called before the first frame update
    void Start()
    {
        setCard(7);
        changeSprite(myParent.regions[getCardID() - 1]); // Subtract one because sprites start at 0 but card ID's start at 1.
        power = 8;
        transferPower = 8;
        income = 8;
        gold = 8;

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