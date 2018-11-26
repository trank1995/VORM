using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChampionDataBase : MonoBehaviour {
    public Dictionary<Champion, List<Texture2D>> championDict { get; set; }
    public List<Texture2D> defaultChampionImage;
	// Use this for initialization
	void Start () {
        championDict = new Dictionary<Champion, List<Texture2D>>();
        setupChampionDB();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public Champion getChampionByID(string id)
    {
        foreach(KeyValuePair<Champion, List<Texture2D>> pair in championDict)
        {
            if (pair.Key.ID == id)
            {
                return pair.Key;
            }
        }
        return null;
    }

    void setupChampionDB()
    {
        championDict.Add(new Champion("default", "c_0", 1, 1, 1), defaultChampionImage);
    }
}
