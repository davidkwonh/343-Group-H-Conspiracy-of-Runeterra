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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 
    public void changeSprite(Sprite newSprite)
    {
        mySprite = GetComponent<SpriteRenderer>();
        mySprite.sprite = newSprite;
    }

    //
    public void setCard(int ID)
    {
        cardID = ID;
    }
    public int getCardID()
    {
        return cardID;
    }
}