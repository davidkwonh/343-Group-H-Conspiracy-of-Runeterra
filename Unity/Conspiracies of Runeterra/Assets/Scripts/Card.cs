using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    // Public Variables
    public Sprite back;

    // Private Variables
    private int cardID;
    private SpriteRenderer mySprite;

    // Set sprite to given sprite.
    public void changeSprite(Sprite newSprite)
    {
        mySprite = GetComponent<SpriteRenderer>();
        mySprite.sprite = newSprite;
    }
    // Change sprite visibility.
    public void spriteVisible()
    {
        if (mySprite.enabled == true)
            mySprite.enabled = false;
        else
            mySprite.enabled = true;
    }

    // Set and Get Card ID
    public void setCard(int ID)
    {
        cardID = ID;
    }
    public int getCardID()
    {
        return cardID;
    }
}