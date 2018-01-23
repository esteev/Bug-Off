using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KaChow : MonoBehaviour {

	private static KaChow instance;
	public static KaChow Instance{get{ return instance; }}

	public Hashtable allRegions;

	void Start () {
		instance = this;
		DontDestroyOnLoad(gameObject);

		if (PlayerPrefs.HasKey ("starter")) {

		} else {
			Save ();
		}
	}

	public void Save()
	{
		
	}
}
