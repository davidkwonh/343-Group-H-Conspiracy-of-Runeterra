using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //
    protected GameObject myRegion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setRegion(GameObject card)
    {
        myRegion = card;
        myRegion.transform.position = transform.position;
        if (this == PlayerController.playerControl.myPlayers[1].GetComponent<Player>())
            myRegion.transform.Rotate(Vector3.forward * 180);
    }
}
