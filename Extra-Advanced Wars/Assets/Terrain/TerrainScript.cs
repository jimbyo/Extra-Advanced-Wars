using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainScript : MonoBehaviour
{
    public bool capturable = false; //false by default. if true, this terrain will have side and income values
    public bool critical = false;//false by default. true only for hq
    public int side=0; //0 for neutral (default), then whatever. relevant only for capturable
    public int income=0;//0 by default, only change on capturable terrain
    //construction related code in a separate script, this script should only hold values for terrain
    public int defense; //must enter for each terrain, no default
    public int[] encumberance; //4 move types: infantry, wheels, treads, air. no default, must enter the 4 values in order for each terrain

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
