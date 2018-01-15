  using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour {

    public float speed = 10.0F;
    public float walkSpeed = 5.0f;

    public float jumpVelocity;
    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2f;
	public bool isGrounded = false;

    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Start () {
        Cursor.lockState = CursorLockMode.Locked;
	}
	
	void Update () {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            float walkTranslation = Input.GetAxis("Vertical") * walkSpeed;
            float walkStraffe = Input.GetAxis("Horizontal") * walkSpeed;
            walkTranslation *= Time.deltaTime;
            walkStraffe *= Time.deltaTime;

            transform.Translate(walkStraffe, 0, walkTranslation);
        }
        else
        {
            float translation = Input.GetAxis("Vertical") * speed;
            float straffe = Input.GetAxis("Horizontal") * speed;
            translation *= Time.deltaTime;
            straffe *= Time.deltaTime;

            transform.Translate(straffe, 0, translation);
        }

        //First part is normal walking, second part is shift walking (just a slower speed)

        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        } else if (rb.velocity.y > 0 && !Input.GetButton("Jump"))
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }

        //First part makes it so we fall faster than we jump, second part makes it so that we hold space to jump higher

		if (Input.GetButtonDown("Jump")&& isGrounded == true)
        {
            GetComponent<Rigidbody>().velocity = Vector3.up * jumpVelocity;
			isGrounded = false;
        }
        
        //Makes us jump

	}
	void OnCollisionStay ()
	{
		isGrounded = true;
	}
}
