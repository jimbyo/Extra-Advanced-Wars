using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainScript : MonoBehaviour {
    public float defenseMultiplier;
    public int moveCost;
    public bool passable;
    //Assign those three variables in the prefabs
    //All terrain-related prefabs need this. Road/Plain/etc will use only this script for terrain-related things, structures will also need
    //a building script, production will also need the appropriate production script

    //Terrain is passable if passable is true AND no enemy unit is on the tile. Terrain cannot be landed on if any unit is on it.
    //Checking if a unit is on a tile will have to be done on the board (2d array) itself
    public float getDefense() { return defenseMultiplier; }
    public int getMoveCost() { return moveCost; }
    public bool getPassable() { return passable; }
}