using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanRotation2 : MonoBehaviour {

	public float rotateMax = 90;
	public float rotateInitial = 0;
	public bool rotate;

	public float speed;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (rotate == true) 
		{
			//transform.rotation = Quaternion.Slerp (Time.time * speed);

			Vector3 currentRotation = transform.localRotation.eulerAngles;
			currentRotation.y = Mathf.Clamp(currentRotation.y, rotateInitial, rotateMax);
			transform.localRotation = Quaternion.Euler (currentRotation);

			rotate = false;
		}
		
	}
	void OnTriggerEnter(Collider trig)
	{
		if (trig.gameObject.tag == "Ball") 
		{
			rotate = true;
		}
		
	}
}
