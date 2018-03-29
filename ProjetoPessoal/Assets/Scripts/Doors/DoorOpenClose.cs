using UnityEngine;
using System.Collections;

public class DoorOpenClose : MonoBehaviour {

	private Animator _animator = null;
	public Collider col;


	// Use this for initialization
	void Start () {
		_animator = GetComponent<Animator>();
	}

	void OnTriggerEnter(Collider col)
	{
		_animator.SetBool("isOpen", true);
		Debug.Log ("isOpen");
	}

	void OnTriggerExit(Collider col)
	{
		_animator.SetBool("isOpen", false);
		Debug.Log ("!isOpen");
	}
}﻿