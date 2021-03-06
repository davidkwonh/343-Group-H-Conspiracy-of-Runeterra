﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // Static variable to allow other objects to interact with this one.
    public static PlayerController playerControl = null;

    // Public Variables
    public GameObject camera;
    public GameObject player;
    public List<GameObject> myPlayers;
    public bool attacked = false;
    public bool addingGold = false;

    // Private Variables
    GameObject currentPlayer;
    GameObject nextPlayer;
    bool activeTurn = false;
    bool rotated = false;

    // Create and enforce singleton.
    private void Awake()
    {
        if (playerControl == null)
            playerControl = this;
        else if (playerControl != this)
            Destroy(gameObject);

        populatePlayers();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("return"))
        {
            if (activeTurn == false)
                endTurn();
            if (addingGold)
                addingGold = false;
        }
        if (Input.GetKey("right"))
        {
            if (rotated)
                camera.transform.position += new Vector3((float)-0.2, 0, 0);
            else
                camera.transform.position += new Vector3((float)0.2, 0, 0);
        }
        if (Input.GetKey("left"))
        {
            if (rotated)
                camera.transform.position += new Vector3((float)0.2, 0, 0);
            else
                camera.transform.position += new Vector3((float)-0.2, 0, 0);
        }
        if (Input.GetKey("up"))
        {
            if (rotated)
                camera.transform.position += new Vector3(0, (float)-0.2, 0);
            else
                camera.transform.position += new Vector3(0, (float)0.2, 0);
        }
        if (Input.GetKey("down"))
        {
            if (rotated)
                camera.transform.position += new Vector3(0, (float)0.2, 0);
            else
                camera.transform.position += new Vector3(0, (float)-0.2, 0);
        }

        // Adding Gold
        if (Input.GetKeyDown("a"))
        {
            if (addingGold)
                currentPlayer.GetComponent<Player>().getRegion().GetComponent<RegionCard>().getChild().spendGold();
        }
    }

    // Create player objects.
    private void populatePlayers()
    {
        myPlayers = new List<GameObject>();
        GameObject instance;

        instance = Instantiate(player, new Vector3(0, -20, 0), Quaternion.identity) as GameObject;
        myPlayers.Add(instance);

        instance = Instantiate(player, new Vector3(0, 20, 0), Quaternion.Euler(180,0,0)) as GameObject;
        myPlayers.Add(instance);
    }
    // Roll dice to determine first player.
    public void rollForFirst()
    {
        int randomIndex = Random.Range(0, myPlayers.Count);
        myPlayers[randomIndex].GetComponent<Player>().setFirstPlayer();
        currentPlayer = myPlayers[randomIndex];
        if (randomIndex == 1)
        {
            camera.transform.Rotate(Vector3.forward * 180);
            UncontrolledArea.uncontrolled.rotateCards();
            rotated = true;
        } 
    }
    // Player turn.
    public IEnumerator sequenceOfPlay()
    {
        activeTurn = true;
        camera.transform.position = currentPlayer.transform.position + new Vector3(0,0,-10);
        //camera.GetComponent<Camera>().orthographicSize = 15; //
        yield return new WaitForSeconds(1f);

        // Determine Next Player.
        if (myPlayers.IndexOf(currentPlayer) + 1 == myPlayers.Count)
            nextPlayer = myPlayers[0];
        else
            nextPlayer = myPlayers[myPlayers.IndexOf(currentPlayer) + 1];

        // Collect Income
        currentPlayer.GetComponent<Player>().collectIncome();
        // Draw a card.
        currentPlayer.GetComponent<Player>().drawCard();
        // Take 2 Actions.
        currentPlayer.GetComponent<Player>().attack();
        while (attacked == false)
        {
            yield return null;
        }
        // Take any free actions.

        // Transfer Money.

        // Take special-power actions.

        // Add targets.
        while (UncontrolledArea.uncontrolled.myHolders.Count < 2)
        {
            UncontrolledArea.uncontrolled.addHolder();
            Deck.deck.addTarget();
        }
        // End Turn.
        activeTurn = false;
    }

    // End players turn.
    private void endTurn()
    {
        // Check if anyone won.
        for (int i = 0; i < myPlayers.Count; i++)
            if (myPlayers[i].GetComponent<Player>().checkWin())
                endGame(i + 1);
        // Go to next player.
        attacked = false;
        camera.transform.Rotate(Vector3.forward * 180);
        UncontrolledArea.uncontrolled.rotateCards();
        rotated = !(rotated);
        currentPlayer = nextPlayer;
        StartCoroutine(sequenceOfPlay());
    }

    // Pass card to player.
    public void attackToControl(GameObject card)
    {
        addingGold = true;
        StartCoroutine(currentPlayer.GetComponent<Player>().attackToControl(card));
    }

    // End game.
    private void endGame(int player)
    {
        StopAllCoroutines();
        print("Player " + player + " wins!");
        SceneManager.LoadScene(0);
    }
}