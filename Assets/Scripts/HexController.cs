using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexController : MonoBehaviour {

    public bool isProcessed = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    void OnMouseDown()
    {
        Color selectedColor = GetComponentInChildren<Renderer>().material.color;
        ProcessExplosion(selectedColor);        
        
    }

    public void ProcessExplosion(Color selectedColor)
    {
        if (GetComponentInChildren<Renderer>().material.color == selectedColor && !isProcessed)
        {
            isProcessed = true;

            //Collider[] hitColliders = Physics.OverlapSphere(transform.position, 10.0f);
            Collider2D[] hitColliders = Physics2D.OverlapCircleAll( transform.position, 1.0f);
            int i = 0;
            while (i < hitColliders.Length)
            {
                if(hitColliders[i].transform.tag == "Tile" && !hitColliders[i].transform.GetComponent<HexController>().isProcessed)
                {
                    //hitColliders[i].SendMessage("ProcessExplosion", selectedColor);                    
                    hitColliders[i].transform.GetComponent<HexController>().ProcessExplosion(selectedColor);
                    Debug.Log("Calling func in : " + hitColliders[i].transform.gameObject.name);
                }
                i++;
            }
            Destroy(this.gameObject);
        }            
    }

}
