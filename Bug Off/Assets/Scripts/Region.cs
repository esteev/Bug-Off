using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum ConLand
{
    Lan, Fibre,
}

public enum ConAir
{
    Bluetooth, WLan, Radio
}

public enum ConSpace
{
    Sat
}

public class Region : MonoBehaviour {

    public float[] connectivity= new float[3];     
    
    public float techLevel;
	
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
