using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basketballThrow : MonoBehaviour 
{
	public float throwForce = 5f;
	public bool canThrow;

    public GameObject playerCamera;

	Rigidbody rigid;

	public BasketBall stop;
	public GameObject Issue;
	public GameObject Spot;
	//public CameraCatch levelStart;

    GameObject prefab;

    private void Start()
    {
        prefab = Resources.Load("projectile") as GameObject;
    }

    void Awake () 
	{
		rigid = GetComponent<Rigidbody> ();
		stop = GetComponent<BasketBall> ();
		transform.parent = null;
		//levelStart = GetComponent<CameraCatch> ();
		//Floating fly = GameObject.FindGameObjectWithTag("Player").GetComponent<Floating> ();
	}
	

	void Update () 
	{
        //float h = Input.GetAxisRaw("Horizontal") * throwForce;
        //float v = Input.GetAxisRaw("Vertical") * throwForce;

        //rigid.velocity = new Vector3(h, v, 0);


		if (Input.GetKey (KeyCode.Mouse0) && canThrow == true) 
		{
            ThrowBall();
            
            //rb.velocity = Camera.main.transform.forward * 40;

            //GetComponent<Rigidbody>().velocity = Vector3.forward * throwForce;
            //transform.parent = null;
            //rigid.isKinematic = false;

            //rigid.useGravity = false;
            //rigid.constraints = RigidbodyConstraints.FreezePosition;
        } else if (canThrow == true)
        {
            transform.position = playerCamera.transform.position + playerCamera.transform.forward;
        }
		
	}
	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == "Player") 
		{
            if (canThrow == false)
            {
                //transform.parent = null;
                canThrow = true;
                Issue.transform.parent = Spot.transform;
                stop.enabled = false;
                rigid.isKinematic = true;
                //rigid.useGravity = true;
                //rigid.constraints = RigidbodyConstraints.FreezePosition;
                transform.localPosition = new Vector3(0, 0, 0);
                Debug.Log("You have picked up the ball!");
                Debug.Log("You can now throw the ball");
            }
		}
	}

    void ThrowBall()
    {
        Debug.Log("You are attempting to throw the ball");

        rigid.isKinematic = false;
        transform.parent = null;
        Debug.Log("isKinematic = off, ball = deparented");

        rigid.AddForce(playerCamera.transform.forward * throwForce, ForceMode.Impulse);
        Debug.Log("Force is added to ball");

        canThrow = false;
        Debug.Log("You can no longer throw the ball");
    }

}
