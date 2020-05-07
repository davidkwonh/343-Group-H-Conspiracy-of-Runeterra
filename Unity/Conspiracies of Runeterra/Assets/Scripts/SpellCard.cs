using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellCard : Card
{
    // Public Variables
    public Sprite[] spells;

    // Protected Variables
    protected SpellCard myParent;
    protected bool inDeck;

    // Set parent to given card.
    public void setParent(SpellCard parent)
    {
        myParent = parent;
    }
}