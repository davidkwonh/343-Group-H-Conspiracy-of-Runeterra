using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardHolder : MonoBehaviour
{
    //
    private GameObject myCard;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void holdCard(GameObject card)
    {
        myCard = card;
        myCard.transform.position = transform.position;
    }
    public bool hasCard()
    {
        if (myCard == null)
            return false;

        return true;
    }
    public GameObject getCard()
    {
        return myCard;
    }
}