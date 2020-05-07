using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardHolder : MonoBehaviour
{
    // Private Variables
    private GameObject myCard;

    // Hold given card.
    public void holdCard(GameObject card)
    {
        myCard = card;
        myCard.transform.position = transform.position;
    }
    // Returns true if holding a card.
    public bool hasCard()
    {
        if (myCard == null)
            return false;

        return true;
    }
    // Returns held card.
    public GameObject getCard()
    {
        return myCard;
    }
}