using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour {

	private Animator animator;

	private const string walkani = "WalkF";
	private const string attackani = "AttackF";


	// Use this for initialization
	void Start () {
		this.animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W)||(Input.GetKey(KeyCode.S)) || (Input.GetKey(KeyCode.A)) || (Input.GetKey(KeyCode.D)))
		{
			this.animator.SetBool(walkani, true);
		}
		else
		{ 
			this.animator.SetBool(walkani, false);
		}
		if (Input.GetButtonDown("Fire1"))
		{
			this.animator.SetBool(attackani, true);
		}
		else
		{ 
			this.animator.SetBool(attackani, false);
		}
	}
}
