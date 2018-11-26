using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleManager : MonoBehaviour {
    public Text name;
    public static Champion playerChampion;
	// Use this for initialization
	void Start () {
        playerChampion = PlayerManager.curPlayerInfo.mainChampion;
        //name.text = PlayerManager.curPlayerInfo.mainChampion.name;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
