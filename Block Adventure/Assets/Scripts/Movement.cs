using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public float speed;

	private Rigidbody rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}


	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}


	void Jump (){
		if (Input.GetKeyDown ("space")) {
			Vector3 playerPos = transform.position;
			playerPos += new Vector3 (0f, 100f, 0f);
			rb.AddForce (playerPos);
		}
	}
}




//
//float moveHorizontal = Input.GetAxis ("Horizontal");
//float moveVertical = Input.GetAxis ("Vertical");
//
//Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
//
//rb.AddForce (movement * speed);