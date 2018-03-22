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
            Vector3 origin = Origin.position;
            Vector3 newDirection = Vector3.RotateTowards(transform.forward, origin, turnSpeed, 0.0F);
            transform.rotation = Quaternion.LookRotation(newDirection);
		} else {
            Vector3 end = End.position;
            Vector3 newDirection = Vector3.RotateTowards(transform.forward, end, turnSpeed, 0.0F);
            transform.rotation = Quaternion.LookRotation(newDirection);
        }
	}

	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == "Ball")
		{
            Debug.Log("The ball has hit the fan");
			rotating = true;
            Debug.Log("The fan is now rotating");
		}
			
		if (col.gameObject.tag == "EndPoints")
			{
				rotating = false;
            Debug.Log("The fan is no longer rotating");
			}
	}
}
