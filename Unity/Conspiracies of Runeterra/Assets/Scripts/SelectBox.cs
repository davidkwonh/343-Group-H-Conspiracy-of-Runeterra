using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectBox : MonoBehaviour
{
    // Private Variables
    GameObject myCard;

    // Select card on mouse click.
    private void OnMouseUp()
    {
        UncontrolledArea.uncontrolled.selectCard(myCard);
    }

    // Set card to given card.
    public void setCard(GameObject card)
    {
        myCard = card;
    }
}