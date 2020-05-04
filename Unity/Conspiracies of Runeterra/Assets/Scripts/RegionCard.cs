using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegionCard : Card
{
    // Public Variables
    public Sprite[] regions;
    public GameObject holder;

    public bool openArrowUp;
    public bool openArrowDown;
    public bool openArrowLeft;
    public bool openArrowRight;

    // Protected Variables
    protected RegionCard myParent;
    protected RegionCard myChild;
    protected int power;
    protected int transferPower;
    protected int income;
    protected int gold;
    protected List<GameObject> openArrows = new List<GameObject>();
    protected List<GameObject> usedArrows = new List<GameObject>();

    protected bool canAttack = true;

    //
    public void setParent(RegionCard parent)
    {
        myParent = parent;
        parent.myChild = this;
    }
    // Add gold from income.
    public void gainIncome()
    {
        gold += income;
    }
    public RegionCard getChild()
    {
        return myChild;
    }
    public bool getAttack()
    {
        return canAttack;
    }
    public int getPower()
    {
        return power;
    }

    // Spawn Card Holders for each open arrow on the card.
    protected void spawnArrows()
    {
        GameObject instance;

        // Top Arrow
        instance = Instantiate(holder, transform.position + new Vector3(15, 0, 0), Quaternion.identity) as GameObject;
        openArrows.Add(instance);
        // Right Arrow
        instance = Instantiate(holder, transform.position + new Vector3(0, 10, 0), Quaternion.identity) as GameObject;
        openArrows.Add(instance);
        // Bottom Arrow
        instance = Instantiate(holder, transform.position + new Vector3(0, -10, 0), Quaternion.identity) as GameObject;
        openArrows.Add(instance);
        // Left Arrow
        instance = Instantiate(holder, transform.position + new Vector3(-15, 0, 0), Quaternion.identity) as GameObject;
        openArrows.Add(instance);
    }
}