using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public Hashtable allRegions, infectedRegions;

	void Start () {
		allRegions = KaChow.Instance.allRegions;
		infectedRegions = new Hashtable ();
	}

	void populate()
	{
		 
	}
	
	void Update () {
		
	}
}
