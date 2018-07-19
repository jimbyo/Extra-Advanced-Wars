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
    //Update 7/11/2018: actually starting stuff again, come back to this script to readapt to what we've planned later
    //Forgotten how we decided units would work in that resuming discussion (in relation to terrain, at least). Probably involved x and y
    //to get current terrain's info in case of combat. How will that work with movement? Since terrain will be uniform, checking move cost
    //will probably just involve checking the space +x or -y away (as examples)
    //Health is simple enough. Being faithful to Advance Wars style stuff will mean that some units will need two weapons (vs infantry
    //will be different from vs vehicle in consideration of things like the mech unit and tanks)
    //isInf will probably need to be a flag
    /*public void capture(Structure s)
    {
        s.capturing(health);
        if (s.getCapturePoints() <= 0)
            s.capture(team);
    }*/
}
