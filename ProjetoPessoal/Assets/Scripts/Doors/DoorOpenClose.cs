﻿using UnityEngine;
using System.Collections;

public class DoorOpenClose : MonoBehaviour {
	public Collider col;
	public Renderer rend;
	public AudioSource doorOpenCloseSound;

	void Start(){
		rend= GetComponentInChildren<Renderer>();
		doorOpenCloseSound = GetComponentInChildren<AudioSource> ();
	}


	void OnTriggerEnter(Collider col){
		Debug.Log ("Enter");
		doorOpenCloseSound.Play ();
		rend.enabled = false;

	}

	void OnTriggerStay(Collider other){
		Debug.Log ("Inside");
	
	}

	void OnTriggerExit(Collider other){
		Debug.Log ("Out");
		rend.enabled = true;
		if (!doorOpenCloseSound.isPlaying) {
			doorOpenCloseSound.Play ();
		}

	}
}﻿