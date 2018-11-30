using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour { 


	public float jumpSpeed = 5f;    

	public bool isGrounded = false; 

	Rigidbody rgbd; 


	// Use this for initialization 
	void Start () { 
		rgbd = GetComponent<Rigidbody>(); 
	} 

	private void OnCollisionEnter(Collision col) 

	{ 

		if (col.gameObject.tag == "Untagged") 

			isGrounded = true; 

		// Update is called once per frame 

	}

	void Update() 
	{ 
		if (isGrounded) 

		{ 

			if (Input.GetKeyDown(KeyCode.Space)) 

			{ 

				rgbd.AddForce(new Vector3(0, 1, 0) * jumpSpeed, ForceMode.Impulse); 

				isGrounded = false; 

			} 

		} 
	}
}