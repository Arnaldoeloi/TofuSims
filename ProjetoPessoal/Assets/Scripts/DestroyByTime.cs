using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByTime : MonoBehaviour {

	public float lifetime;

	// Use this for initialization
	void Start () {
		Destroy (gameObject, lifetime);
	}

	void Update(){
		transform.localScale += new Vector3 (-0.01f, -0.01f, -0.01f);
	}

}
