using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraCatch : MonoBehaviour {

	public bool notDead = false;
	// Use this for initialization
	public string newLevel;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnTriggerEnter (Collider trig)
	{
		if (trig.gameObject.tag == "Camera") {
			//transform.position = new Vector3(0,0,0);
			SceneManager.LoadScene(newLevel);
		}	
	}
}
