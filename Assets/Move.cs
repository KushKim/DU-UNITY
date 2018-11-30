using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour { 

	public int Speed = 2; 
	private float sanX = 15.0f;

	// Use this for initialization 
	void Start () {
		
	}

	// Update is called once per frame
	void Update () { 
		transform.Rotate(0, Input.GetAxis("Mouse X") * sanX, 0);

		float keyHorizontal = Input.GetAxis("Horizontal"); 
		float keyVertical = Input.GetAxis("Vertical"); 

		transform.Translate(Vector3.right * Speed * Time.smoothDeltaTime * keyHorizontal); 
		transform.Translate(Vector3.forward * Speed * Time.smoothDeltaTime * keyVertical); 
	}
}