﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UncontrolledArea : MonoBehaviour
{
    // Global Variables
    public static UncontrolledArea uncontrolled = null;

    // Public Variables
    public GameObject holder;
    public GameObject select;
    public List<GameObject> myHolders;
    public List<GameObject> mySelects;

    // Create and enforce singleton.
    private void Awake()
    {
        if (uncontrolled == null)
            uncontrolled = this;
        else if (uncontrolled != this)
            Destroy(gameObject);

        spawnHolders();
    }

    // Create initial card holders.
    void spawnHolders()
    {
        myHolders = new List<GameObject>();
        GameObject instance;

        instance = Instantiate(holder, transform.position + new Vector3(0, 5, 0), Quaternion.identity) as GameObject;
        myHolders.Add(instance);
        instance = Instantiate(holder, transform.position + new Vector3(0, -5, 0), Quaternion.identity) as GameObject;
        myHolders.Add(instance);
        instance = Instantiate(holder, transform.position + new Vector3(15, 5, 0), Quaternion.identity) as GameObject;
        myHolders.Add(instance);
        instance = Instantiate(holder, transform.position + new Vector3(15, -5, 0), Quaternion.identity) as GameObject;
        myHolders.Add(instance);
    }
    // Create new card holder.
    public void addHolder()
    {
        GameObject instance;
        Vector3 newPostition;

        if (myHolders.Count < 1)
            newPostition = transform.position + new Vector3(0, 5, 0);
        else if (myHolders.Count % 2 == 0)
            newPostition = myHolders[myHolders.Count - 2].transform.position + new Vector3(15, 0, 0);
        else
            newPostition = myHolders[myHolders.Count - 1].transform.position + new Vector3(0, -10, 0);

        instance = Instantiate(holder, newPostition, Quaternion.identity) as GameObject;
        myHolders.Add(instance);
    }

    // Rotate held cards.
    public void rotateCards()
    {
        for (int i = 0; i < myHolders.Count; i++)
            myHolders[i].GetComponent<CardHolder>().getCard().transform.Rotate(Vector3.forward * 180);
    }

    // Create selection box for each card holder.
    public void spawnSelectBoxes()
    {
        GameObject instance;
        for (int i = 0; i < myHolders.Count; i++)
        {
            instance = Instantiate(select, myHolders[i].transform.position, Quaternion.identity) as GameObject;
            instance.GetComponent<SelectBox>().setCard(myHolders[i]);
            mySelects.Add(instance);
        }
    }

    // Pass selected card to player controller, and destroy selection boxes.
    public void selectCard(GameObject card)
    {
        while (mySelects.Count > 0)
        {
            Destroy(mySelects[0]);
            mySelects.RemoveAt(0);
        }

        myHolders.Remove(card);
        PlayerController.playerControl.attackToControl(card.GetComponent<CardHolder>().getCard());
    }

    // Update card positions after attack.
    public void updateCards()
    {
        List<GameObject> temp = new List<GameObject>();
        while (myHolders.Count > 0)
        {
            temp.Add(myHolders[0].GetComponent<CardHolder>().getCard());
            Destroy(myHolders[0]);
            myHolders.RemoveAt(0);
        }

        for (int i = 0; i < temp.Count; i++)
        {
            addHolder();
            myHolders[i].GetComponent<CardHolder>().holdCard(temp[i]);
        }
    }
}