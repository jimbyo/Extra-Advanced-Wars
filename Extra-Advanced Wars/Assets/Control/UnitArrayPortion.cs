using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitArrayPortion : MonoBehaviour
{
    private GameObject[,] unitBoard;
    public int length, width;
    // Use this for initialization
    void Start () {
        unitBoard = new GameObject[length,width];
        for (int l = 0; l < length; ++l)
        {
            for (int w = 0; w < width; ++w)
            { unitBoard[l,w] = new GameObject(); }
        }
	}
	

    public GameObject getUnit(int x, int y)
    {
        return unitBoard[y, x];
    }
    public void removeUnit(int x, int y)
    {
        unitBoard[y, x] = new GameObject();
    }
    public void setUnit(int x, int y, GameObject g)
    {
        unitBoard[y, x] = g;
    }
}
