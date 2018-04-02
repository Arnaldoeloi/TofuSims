using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FeelingInfluence : MonoBehaviour {


	public String areaOfInfluenceTag="areaOfInfluence";
	private Animator anim;
	// Use this for initialization
	void Start () {
		anim=this.GetComponent<Animator> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay(Collider col){
		//Debug.Log ("AI Enter:");
		if (col.transform.CompareTag (areaOfInfluenceTag)) {
			Debug.Log ("Area of Influence");
			this.GetComponent<Needs> ().boredom += (col.transform.GetComponentInParent<InteractiveElement> ().goodForBoredom) / 150;
			this.GetComponent<Needs> ().tireness += (col.transform.GetComponentInParent<InteractiveElement> ().goodForTireness) / 150;
			this.GetComponent<Needs> ().social += (col.transform.GetComponentInParent<InteractiveElement> ().goodForSocial) / 150;
			this.GetComponent<Needs> ().hunger += (col.transform.GetComponentInParent<InteractiveElement> ().goodForHunger) / 150;

			

			if (col.transform.GetComponentInParent<audioPlayerController> ()!=null && col.transform.GetComponentInParent<audioPlayerController> ().goodForBoredom > 0) {
				anim.SetBool ("isDancing", true);
			} else {
				anim.SetBool ("isDancing", false);
			}

		} 
	}

}
