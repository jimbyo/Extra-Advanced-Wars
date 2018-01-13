using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Structure : MonoBehaviour {
    public int income,team,capturePoints=20;
    public bool isCritical;
    //use isCritical for command centers. 0 for neutral team

    public void capturing(int health) //to be called by capturing infantry
    { capturePoints -= health; }
    public int getIncome()
    { return income; }
    public int getTeam()
    { return team; }
    public bool criticalCheck() //to be checked on board after a building is captured - it is a win condition, afer all
    { return isCritical; }

    public void capture(int capturer) 
    //to be called when structure is captured by infantry - most of capture process to be done in infantry script
    { 
        team = capturer;
        resetCapture();
    }

    public void resetCapture() 
    //called when a structure is captured or the capturing unit dies or moves - called from board whenever a unit's move is confirmed and
    //infantry is no longer on a building
    { capturePoints = 20; }
}
