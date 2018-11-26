using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class PlayerInfo : System.Object {
    public Champion mainChampion { get; set; } //main character
    public string playerID { get; set; }
    public List<Champion> champions { get; set; } //These are helper champions, like party member
    public List<Minion> minions { get; set; }
    
    public PlayerInfo()
    {

    }
    public PlayerInfo(Champion inMain, string inPlayerID, List<Champion>  inChampions, List<Minion> inMinions)
    {
        mainChampion = inMain;
        playerID = inPlayerID;
        champions = inChampions;
        minions = inMinions;
    }
}
