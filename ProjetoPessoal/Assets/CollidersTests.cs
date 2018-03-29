using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollidersTests : MonoBehaviour {



	void OnTriggerEnter (Collider other){
		Debug.Log ("Entrou");

	}

	void onTriggerStay (Collider other){
		Debug.Log ("Está dentro");
	}

	void onTriggerExit (Collider other){
		Debug.Log ("Saiu");
	}
}
