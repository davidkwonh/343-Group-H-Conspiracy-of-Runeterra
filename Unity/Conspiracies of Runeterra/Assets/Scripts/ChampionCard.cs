using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChampionCard : Card
{
    // Public Variables
    public Sprite[] champions;
    public GameObject treasury;

    // Protected Variables
    protected ChampionCard myParent;
    protected ChampionCard myChild;
    protected int power;
    protected int transferPower;
    protected int resistance;
    protected int income;
    protected int gold;
    protected GameObject myTreasury;
    protected List<String> alignments = new List<String>();

    // Start is called before the first frame update
    /*void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }*/
    public ChampionCard getChild()
    {
        return myChild;
    }
    public int getResistance()
    {
        return resistance;
    }

    public void setParent(ChampionCard parent)
    {
        myParent = parent;
        parent.myChild = this;

        GameObject instance;
        instance = Instantiate(parent.treasury, transform.position, transform.rotation) as GameObject;
        instance.GetComponent<Treasury>().setParent(this);
        myTreasury = instance;
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

    // Check if same alignment.
    public bool isSame(String align)
    {
        if (align == "Shadow Spirit")
            return false;

        return alignments.Contains(align);
    }

    // Check if opposite alignment.
    public bool isOpposite(String align)
    {
        // Demacian vs. Ionian
        if (align == "Demacian")
            return alignments.Contains("Ionian");
        else if (align == "Ionian")
            return alignments.Contains("Demacian");

        // Freljordian vs. Monster
        if (align == "Freljordian")
            return alignments.Contains("Monster");
        else if (align == "Monster")
            return alignments.Contains("Freljordian");

        // Noxian vs. Zaunist
        if (align == "Noxian")
            return alignments.Contains("Zaunist");
        else if (align == "Zaunist")
            return alignments.Contains("Noxian");

        // Yordle vs. Shuriman
        if (align == "Yordle")
            return alignments.Contains("Shuriman");
        else if (align == "Shuriman")
            return alignments.Contains("Yordle");

        // Shadow Spirit vs. Shadow Spirit
        if (align == "Shadow Spirit")
            return alignments.Contains("Shadow Spirit");

        // Void no opposite.
        return false;
    }
}