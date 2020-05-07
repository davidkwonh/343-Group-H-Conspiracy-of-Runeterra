using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegionCard : Card
{
    // Public Variables

    // All region card sprites.
    public Sprite[] regions;
    // Card holder object.
    public GameObject holder;
    // Treasury object.
    public GameObject treasury;

    // Protected Variables

    // Links region classes and card objects.
    protected RegionCard myParent;
    protected RegionCard myChild;
    // Card attributes.
    protected int power;
    protected int transferPower;
    protected int income;
    protected int gold;
    //
    protected bool canAttack = true;
    // Treasury object to make gold visible to the player.
    protected GameObject myTreasury;
    // Card holders for each arrow on the card.
    protected List<GameObject> openArrows;
    protected List<GameObject> usedArrows;

    // Methods

    // Link parent card object to this region object.
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
    public int getGold()
    {
        return gold;
    }
    public void spendGold()
    {
        if (gold != 0)
        {
            gold -= 1;
            power += 1;
        }
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
    public void resetPower(int original)
    {
        power = original;
    }

    // Spawn Card Holders for each open arrow on the card.
    protected void spawnArrows()
    {
        openArrows = new List<GameObject>();
        usedArrows = new List<GameObject>();
        GameObject instance;

        // Top Arrow
        instance = Instantiate(myParent.holder, transform.position + new Vector3(15, 0, 0), Quaternion.identity) as GameObject;
        openArrows.Add(instance);
        // Right Arrow
        instance = Instantiate(myParent.holder, transform.position + new Vector3(0, 10, 0), Quaternion.identity) as GameObject;
        openArrows.Add(instance);
        // Bottom Arrow
        instance = Instantiate(myParent.holder, transform.position + new Vector3(0, -10, 0), Quaternion.identity) as GameObject;
        openArrows.Add(instance);
        // Left Arrow
        instance = Instantiate(myParent.holder, transform.position + new Vector3(-15, 0, 0), Quaternion.identity) as GameObject;
        openArrows.Add(instance);

        // Treasury
        instance = Instantiate(myParent.treasury, transform.position, transform.rotation) as GameObject;
        instance.GetComponent<Treasury>().setParent(this);
        myTreasury = instance;
    }

    //
    public GameObject getOpenArrow()
    {
        if (openArrows.Count == 0)
            return null;

        for (int i = 0; i < openArrows.Count; i++)
        {
            if (openArrows[i].GetComponent<CardHolder>().hasCard() == false)
                return openArrows[i];
        }
        return null;
    }
    public void fillArrow()
    {
        usedArrows.Add(openArrows[0]);
        openArrows.RemoveAt(0);
    }
}