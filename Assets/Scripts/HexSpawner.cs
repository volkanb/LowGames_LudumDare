using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexSpawner : MonoBehaviour {

    public GameObject hex;
    public float startDelay = 2.0f;
    public float spawnDelay = 2.0f;

    // Use this for initialization
    void Start () {
        InvokeRepeating("SpawnHex", startDelay, spawnDelay);

    }
	
    void SpawnHex()
    {
        Color randColor = Color.gray;
        int randInt = (int)Random.Range(0f, 3.0f);
        switch (randInt)
        {
            case 0:
                randColor = Color.blue;
                break;
            case 1:
                randColor = Color.green;
                break;
            case 2:
                randColor = Color.red;
                break;
            case 3:
                randColor = Color.yellow;
                break;
        }
        GameObject newHex = Instantiate(hex, transform.position, Quaternion.identity);
        newHex.GetComponentInChildren<Renderer>().material.SetColor("_Color", randColor);
    }

}
