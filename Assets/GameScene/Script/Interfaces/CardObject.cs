using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardObject : MonoBehaviour {
    public Card card;
    public SlotObject curSlot;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //showAvailbleSlot();
	}
    public void OnMouseDown()
    {
        showAvailbleSlot();
    }
    public void showAvailbleSlot()
    {
        if (curSlot != null)
        {
            foreach (Slot s in curSlot.slot.getAvailableSlots(3))
            {
                BoardManager.slotObjects[s.x, s.y].GetComponent<SpriteRenderer>().color = new Color(0, 225, 0);
            }
        }
        
    }
    public void placeCard(SlotObject slot)
    {
        curSlot = slot;
        transform.position = curSlot.transform.position;
        showAvailbleSlot();
    } 
}
