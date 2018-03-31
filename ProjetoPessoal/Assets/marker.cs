using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class marker : MonoBehaviour {
	Vector3 v;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		v= v * Time.deltaTime;

	}
}
