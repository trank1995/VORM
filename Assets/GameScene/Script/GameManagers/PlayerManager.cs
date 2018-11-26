using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {
    public static PlayerInfo curPlayerInfo { get; set; }
                                      
    void Start () {
        loadPlayer();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void loadPlayer()
    {
        Champion mainCharacter = new Champion("Default main", "c_0", 3, 3, 3);
        List<Champion> champions = new List<Champion>
        {
            new Champion("default_champ", "c_1", 3, 2, 1)
        };
        List<Minion> minions = new List<Minion>
        {
            new Minion("default_minion", "m_1", 3, 2, 1)
        };
        curPlayerInfo = new PlayerInfo(mainCharacter, "p_1", champions, minions);
        Debug.Log(curPlayerInfo.mainChampion.name);
    }

}
