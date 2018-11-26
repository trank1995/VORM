using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This class is for user interaction and interface, use slot class to put logical stuff
public class SlotObject : MonoBehaviour {
    public Slot slot { get; set; }
                                       // Use this for initialization
    void Start () {
        transform.GetComponent<SpriteRenderer>().color = new Color(255, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnMouseDown()
    {

    }
}
