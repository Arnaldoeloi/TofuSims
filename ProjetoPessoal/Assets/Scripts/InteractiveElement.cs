using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngineInternal;

public abstract class InteractiveElement : MonoBehaviour {


	public float goodForBoredom = 0.0f;
	public float goodForTireness = 0.0f;
	public float goodForHunger = 0.0f;
	public float goodForSocial = 0.0f;
	public float goodForBathroom = 0.0f;
	public float goodForShower = 0.0f;



	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public abstract void execute();
}
