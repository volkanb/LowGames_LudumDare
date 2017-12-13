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
        Instantiate(hex, transform.position, Quaternion.identity);
    }

}
