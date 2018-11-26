using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour {
    public static  BoardManager boardManager;
    public static float scale = 1.3f;
    public static int xGridSize = 5;
    public static int yGridSize = 5;
    public static SlotObject[,] slotObjects;
    public static float minScale = .5f;
    public static float maxScale = 2f;
    public GameObject slot, path, card;
    public static List<PlayerInfo> players;
    public static PlayerInfo curPlayer;
    // Use this for initialization
    void Start () {
        card.SetActive(false);
        boardManager = this;
        players = new List<PlayerInfo>();
        players.Add(new PlayerInfo());

        slotObjects = new SlotObject[xGridSize, yGridSize];
        deployGirdSlots();
        deployMainChampions();

	}
	
	// Update is called once per frame
	void Update () {
        

	}
    void deployMainChampions()
    {
        CardObject co = Object.Instantiate(card, card.transform.parent).GetComponent<CardObject>();
        co.card = BattleManager.playerChampion;
        co.placeCard(slotObjects[(int)(xGridSize / 2), 0]);
        co.gameObject.SetActive(true);
    }
    void deployGirdSlots()
    {
        float width = transform.GetComponent<SpriteRenderer>().bounds.size.x;
        float height = transform.GetComponent<SpriteRenderer>().bounds.size.y;
        float xOffset = width/xGridSize;
        float yOffset = height/yGridSize;
        for (int x = 0; x < xGridSize; x++)
        {
            for(int y = 0; y < yGridSize; y++)
            {
                Slot s = new Slot(x, y);
                SlotObject so = Object.Instantiate(slot, slot.transform.parent).GetComponent<SlotObject>();
                so.slot = s;

                so.transform.position = new Vector3(xOffset * (.5f+x) - width / 2, yOffset * (.5f+y) - height / 2, transform.position.z);
                slotObjects[x, y] = so;
            }
        }
        foreach(SlotObject so in slotObjects)
        {
            so.slot.setNeighborFull(xGridSize, yGridSize);
        }
        foreach (SlotObject so in slotObjects)
        {
            foreach(Slot s in so.slot.neighbors)
            {
                Path p = Object.Instantiate(path, path.transform.parent).GetComponent<Path>();
                p.fromObj = so.gameObject;
                p.toObj = slotObjects[s.x, s.y].gameObject;
                p.drawLine();
            }
        }
        path.SetActive(false);
        slot.SetActive(false);
    }

    
}
