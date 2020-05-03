using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Static variable to allow other objects to interact with this one.
    public static PlayerController playerControl = null;

    //
    public GameObject player;

    // Private Variables
    public List<GameObject> myPlayers;

    //
    private void Awake()
    {
        if (playerControl == null)
            playerControl = this;
        else if (playerControl != this)
            Destroy(gameObject);

        populatePlayers();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //
    private void populatePlayers()
    {
        myPlayers = new List<GameObject>();
        GameObject instance;

        instance = Instantiate(player, new Vector3(0, -10, 0), Quaternion.identity) as GameObject;
        instance.AddComponent<Player1>();
        myPlayers.Add(instance);

        instance = Instantiate(player, new Vector3(0, 10, 0), Quaternion.identity) as GameObject;
        instance.AddComponent<Player2>();
        myPlayers.Add(instance);
    }
}