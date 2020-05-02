using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChampionCard : Card
{
    // Public Variables
    public Sprite[] champions;

    // Protected Variables
    protected int power;
    protected int transferPower;
    protected int resistance;
    protected int income;
    protected int gold;
    protected List<String> alignments;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    /*
    // Update is called once per frame
    void Update()
    {
        
    }*/

    // Add gold from income.
    public void gainIncome()
    {
        gold += income;
    }
}