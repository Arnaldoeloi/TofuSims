using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : InteractiveElement {

	private Renderer rend;

	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public override void execute(){
		rend.enabled = false;
		GameObject.DestroyObject(this);
	}
}
