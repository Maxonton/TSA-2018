using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entry : MonoBehaviour {

	public float timeUp = 3;
	public float force = 5;
	
	public Rigidbody rigid;

	// Use this for initialization
	private void Awake () {
		
		rigid = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		timeUp -= Time.deltaTime;
		if (timeUp < 0) {
			GetComponent<Rigidbody> ().velocity = Vector3.up * force;
		}
			
		
	}
		
}
