using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //
    private GameObject myRegion;
    private List<GameObject> myChamps = new List<GameObject>();
    private bool isFirst;
    // Start is called before the first frame update
    void Start()
    {
        isFirst = false;
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
    public void setFirstPlayer()
    {
        isFirst = true;
    }

    //
    public void collectIncome()
    {
        myRegion.GetComponent<RegionCard>().getChild().gainIncome();
    }
}
