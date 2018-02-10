using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basketballThrow : MonoBehaviour 
{
	public float throwForce = 5;
	public bool canThrow;

	Rigidbody rigid;
	public BasketBall stop;
	public GameObject Issue;
	public GameObject Spot;
	//public CameraCatch levelStart;


	// Use this for initialization
	void Awake () 
	{
		rigid = GetComponent<Rigidbody> ();
		stop = GetComponent<BasketBall> ();
		transform.parent = null;
		//levelStart = GetComponent<CameraCatch> ();
		//Floating fly = GameObject.FindGameObjectWithTag("Player").GetComponent<Floating> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey (KeyCode.Mouse0) && canThrow == true) 
		{
			GetComponent<Rigidbody>().velocity = Vector3.forward * throwForce;
			transform.parent = null;
			rigid.isKinematic = false;
			//rigid.useGravity = false;
			//rigid.constraints = RigidbodyConstraints.FreezePosition;
		}
		
	}
	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == "Player") 
		{
			//transform.parent = null;
			canThrow = true;
			Issue.transform.parent = Spot.transform;
			stop.enabled = false;
			rigid.isKinematic = true;
			//rigid.useGravity = true;
			//rigid.constraints = RigidbodyConstraints.FreezePosition;
			transform.localPosition = new Vector3(0,0,0);
		}
	}
}
