using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : RegionCard
{
    // Start is called before the first frame update
    void Start()
    {
        setCard(4);
        changeSprite(myParent.regions[getCardID() - 1]); // Subtract one because sprites start at 0 but card ID's start at 1.
        power = 7;
        transferPower = 7;
        income = 12;
        gold = 12;

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