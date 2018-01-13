using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainArray : MonoBehaviour {
    public length =10:
    public width = 20:

	// Use this for initialization
	void Start () {
        int[,] array = new int[length,width]
		
	}
    public array createMap()
    {
        int[,] array = new int[10, 20]
        for(int=0; int<length)
        //setting up roads
        for (int i = 3; i < 16; i++)
        {
            for(int j = 3; j<9; j++)
            {
                array[i,j] = 2
            }


        }

    }
	// Update is called once per frame
	void Update () {
		
	}
}
