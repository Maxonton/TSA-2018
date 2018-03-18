using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanRotation3 : MonoBehaviour 
{
	public Transform Origin;
	public Transform End;
	public float speed = 10F;
	public bool Switch = false;
	public bool rotating = false;
	public float turnSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		if (rotating == true) {
			FanMove ();
		}
		turnSpeed = speed * Time.deltaTime;
	}

	void FanMove(){
		if (transform.rotation == End.rotation) {
			Switch = true;
		}
		if (transform.rotation == Origin.rotation) {
			Switch = false;
		}

		if (Switch) {
			transform.rotation = Vector3.RotateTowards (transform.rotation, Origin.rotation, turnSpeed, 0.0F);
		} else {
			transform.rotation = Vector3.RotateTowards (transform.rotation, End.rotation, turnSpeed, 0.0F);
		}
	}

	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == "Ball")
		{
			rotating = true;
		}
			
		if (col.gameObject.tag == "EndPoints")
			{
				rotating = false;
			}
	}
}
