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

    /*// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/
    public void setParent(SpellCard parent)
    {
        myParent = parent;
    }
}