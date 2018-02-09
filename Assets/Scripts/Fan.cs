using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fan : MonoBehaviour 
{
	public float forward;

	public Rigidbody rb;
	// Use this for initialization
	void Awake () 
	{
		rb = GetComponent<Rigidbody> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter (Collider trig)
	{
		if (trig.gameObject.tag == "fan") {
			GetComponent<Rigidbody> ().velocity = Vector3.forward * forward;
		}	
	}
}
