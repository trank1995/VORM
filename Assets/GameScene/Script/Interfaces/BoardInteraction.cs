using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardInteraction : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        zoom();
        if (Input.anyKey)
        {
            transform.localScale = new Vector3(BoardManager.scale, BoardManager.scale, 0);
            BoardManager.boardManager.card.GetComponent<CardObject>().placeCard(BoardManager.slotObjects[0, 0]);
        }
    }

    //TO CHANGE: MOVE CAMERA INSTEAD OF CHANGING THE SCALE
    void zoom()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow) && BoardManager.scale >= BoardManager.minScale)
        {
            BoardManager.scale -= 0.1f;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && BoardManager.scale <= BoardManager.maxScale)
        {
            BoardManager.scale += 0.1f;
        }
    }
}
