using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treasury : MonoBehaviour
{
    //
    public Sprite[] goldSprites;
    //
    RegionCard myRegion;
    ChampionCard myChamp;
    SpriteRenderer mySprite;

    // Start is called before the first frame update
    void Start()
    {
        mySprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        int gold = 0;
        if (myRegion != null)
            gold = myRegion.getGold();
        if (myChamp != null)
            gold = myChamp.getGold();

        if (gold < 10)
            mySprite.sprite = goldSprites[gold];
        else
            mySprite.sprite = goldSprites[10];

        if (myRegion != null)
        {
            if (transform.position != myRegion.transform.position)
                transform.position = myRegion.transform.position;
            if (transform.rotation != myRegion.transform.rotation)
                transform.rotation = myRegion.transform.rotation;
        }
            

        if (myChamp != null)
        {
            if (transform.position != myChamp.transform.position)
                transform.position = myChamp.transform.position;
            if (transform.rotation != myChamp.transform.rotation)
                transform.rotation = myChamp.transform.rotation;
        }
    }

    public void setParent(RegionCard parent)
    {
        myRegion = parent;
    }
    public void setParent(ChampionCard parent)
    {
        myChamp = parent;
    }
}