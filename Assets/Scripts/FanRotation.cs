using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanRotation : MonoBehaviour 
{
	public Transform from;
	public Transform to;
	public float speed;
	public bool rotation = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (rotation == true) {
			transform.rotation = Quaternion.Slerp (from.rotation, to.rotation, Time.time * speed);
			rotation = false;
		}
		
	}

	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == "ball")
			{
				rotation = true;
			}
	}
}
