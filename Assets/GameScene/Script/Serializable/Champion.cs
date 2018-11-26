using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Champion : Card {
    public Champion(string inName, string inID, int mHealth, int oAttackDamage, int mActionPoint) : base(inName, inID, mHealth, oAttackDamage, mActionPoint)
    {
    }

    public int resource { get; set; }
    public int deployRange { get; set; }
    

}
