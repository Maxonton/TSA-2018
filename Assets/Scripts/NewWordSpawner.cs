using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewWordSpawner : MonoBehaviour {

	public float ScreenHeight;
	public float ScreenWidth;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 position = new Vector2 (Random.Range (0, ScreenWidth), Random.Range (0, ScreenHeight));
		
	}
}
