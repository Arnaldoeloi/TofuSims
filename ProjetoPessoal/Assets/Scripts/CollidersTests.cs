using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollidersTests : MonoBehaviour {

	public Renderer rend;

	void Start(){
		
		rend = GetComponentInChildren<Renderer> ();
		rend.enabled = true;
	}

	void onTriggerStay (Collider other){
		Debug.Log ("Está dentro");
	}

	void OnTriggerEnter (Collider other){
		Debug.Log ("Entrou");
		rend.enabled = false;

	}

	void onTriggerExit (Collider other){
		Debug.Log ("Saiu");
	}
	 

}
