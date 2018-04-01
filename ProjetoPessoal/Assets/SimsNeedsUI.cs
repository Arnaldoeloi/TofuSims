using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class SimsNeedsUI : MonoBehaviour {

	private Needs needs;
	public Slider hungerBar;
	public Slider boredomBar;
	public Slider tirenessBar;
	public Slider socialBar;

	private Slider[] needsSliders;


	public GameObject simsCharacter;


	// Use this for initialization
	void Start () {
		needs = (Needs) simsCharacter.GetComponent ("Needs");
		needsSliders = this.GetComponentsInChildren<Slider> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		hungerBar.value = needs.hunger/100f;
		boredomBar.value = needs.boredom/100f;
		tirenessBar.value = needs.tireness/100f;
		socialBar.value = needs.social/100f;

		
		foreach (Slider slider in needsSliders) {
			if (slider.value > 0.8) {
				slider.GetComponentInChildren<Image> ().color = Color.green;
			} else if (slider.value <= 0.8 && slider.value > 0.3) {
				slider.GetComponentInChildren<Image> ().color = Color.yellow;
			} else {
				slider.GetComponentInChildren<Image> ().color = Color.red;
			}
		}


		/*
		hungerBar.GetComponentInChildren<Image>().color=Color.green;
		boredomBar.GetComponentInChildren<Image>().color=Color.green;
		tirenessBar.GetComponentInChildren<Image>().color=Color.green;
		socialBar.GetComponentInChildren<Image>().color=Color.green;
		*/


		/*
		Debug.Log ("UI Boredom Value="+needs.boredom);
		Debug.Log ("UI Social Value="+needs.social);
		Debug.Log ("UI Tireness Value="+needs.tireness);
		Debug.Log ("UI Hunger Value="+needs.hunger);
		*/
	}
}
