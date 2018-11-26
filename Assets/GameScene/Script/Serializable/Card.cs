using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Card : System.Object
{
    public string name { get; set; }
    public string ID { get; set; }
    public faction faction { get; set; }
    public int maxHealth { get; set; }
    public int originalAttackDamage { get; set; }
    public int maxActionPoint { get; set; }
    public bool shield { get; set; } //might or might not use
    public int health { get; set; }
    public int attackDamage { get; set; }
    public int actionPoint { get; set; }
    public Card()
    {

    }
    public Card(string inName, string inID, int mHealth, int oAttackDamage, int mActionPoint)
    {
        name = inName;
        ID = inID;
        maxHealth = mHealth;
        originalAttackDamage = oAttackDamage;
        maxActionPoint = mActionPoint;
    }

    protected void refillHealth()
    {
        health = maxHealth;
    }
    protected void refillActionPoint()
    {
        actionPoint = maxActionPoint;
    }
    protected void resetAttackDamage()
    {
        attackDamage = originalAttackDamage;
    }
    
}

public enum faction
{
    a,
    b,
    c
}