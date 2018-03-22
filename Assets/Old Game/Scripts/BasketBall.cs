using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketBall : MonoBehaviour {

	public float upForce = 5;
	public bool canJump = false;

	public Rigidbody ball;
	// Use this for initialization
	private void Awake () 
	{
		ball = GetComponent<Rigidbody> ();
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (canJump == true) 
		{
			GetComponent<Rigidbody> ().velocity = Vector3.up * upForce;
			canJump = false;
		}
	}
	void OnCollisionStay()
	{
		canJump = true;
			
	}
}
