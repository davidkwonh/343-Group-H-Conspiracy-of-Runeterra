﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkDash : SpellCard
{
    // Start is called before the first frame update
    void Start()
    {
        setCard(9);
        changeSprite(myParent.spells[getCardID() - 1]); // Subtract one because sprites start at 0 but card ID's start at 1.
        inDeck = true;
    }
    /*
    // Update is called once per frame
    void Update()
    {
        
    }*/
}