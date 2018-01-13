using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour {

    public int moveSpeed, maxHealth,team,cost;
    public float damage, defense;
    public bool isInf;
    private int health;

    void Start()
    {
        health = maxHealth;
    }

    public int getCost()
    { return cost; }
    public int getSpeed()
    { return moveSpeed; }
    public int getMaxHealth()
    { return maxHealth; }
    public int getHealth()
    { return health; }
    public float getDamage()
    { return damage; }
    public float getDefense()
    { return defense; }
    public bool infantry()
    { return isInf; }

    //This part should relate to capturing structures and should only be called by the board after checking infantry()
    public void capture(Structure s)
    {
        s.capturing(health);
        if (s.getCapturePoints() <= 0)
            s.capture(team);
    }
}
