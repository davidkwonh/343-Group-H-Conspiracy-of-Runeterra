using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UncontrolledArea : MonoBehaviour
{
    public static UncontrolledArea uncontrolled = null;
    //
    public GameObject holder;
    public List<GameObject> myHolders;

    //
    private void Awake()
    {
        if (uncontrolled == null)
            uncontrolled = this;
        else if (uncontrolled != this)
            Destroy(gameObject);

        spawnHolders();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnHolders()
    {
        myHolders = new List<GameObject>();
        GameObject instance;

        instance = Instantiate(holder, transform.position + new Vector3(0, 15, 0), Quaternion.identity) as GameObject;
        myHolders.Add(instance);

        instance = Instantiate(holder, transform.position + new Vector3(0, 5, 0), Quaternion.identity) as GameObject;
        myHolders.Add(instance);

        instance = Instantiate(holder, transform.position + new Vector3(0, -15, 0), Quaternion.identity) as GameObject;
        myHolders.Add(instance);

        instance = Instantiate(holder, transform.position + new Vector3(0, -5, 0), Quaternion.identity) as GameObject;
        myHolders.Add(instance);
    }

    //
    public void addHolder()
    {
        GameObject instance;
        Vector3 newPostition;

        if (myHolders.Count < 1)
            newPostition = transform.position + new Vector3(0, 15, 0);
        else if (myHolders.Count % 4 == 0)
            newPostition = myHolders[myHolders.Count - 4].transform.position + new Vector3(20, 0, 0);
        else
            newPostition = myHolders[myHolders.Count - 1].transform.position + new Vector3(0, -10, 0);

        instance = Instantiate(holder, newPostition, Quaternion.identity) as GameObject;
        myHolders.Add(instance);
    }
}