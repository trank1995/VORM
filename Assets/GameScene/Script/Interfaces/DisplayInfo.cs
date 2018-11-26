using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayInfo : MonoBehaviour {
    public Text health;
    Card currentCard;
	// Use this for initialization
	void Start () {
        currentCard = new Card("default champ", "c_1", 3, 2, 1);
        health.text = currentCard.health.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
