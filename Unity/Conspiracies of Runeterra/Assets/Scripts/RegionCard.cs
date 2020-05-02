using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegionCard : Card
{
    // Public Variables
    public Sprite[] regions;

    // Protected Variables
    protected RegionCard myParent;
    protected int power;
    protected int transferPower;
    protected int income;
    protected int gold;

    // Start is called before the first frame update
    /*void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/

    public void setParent(RegionCard parent)
    {
        myParent = parent;
    }
    // Add gold from income.
    public void gainIncome()
    {
        gold += income;
    }
}