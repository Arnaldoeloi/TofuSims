using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimsNeedsUI : MonoBehaviour {

	private Needs needs;
	public Slider hungerBar;
	public Slider boredomBar;
	public Slider tirenessBar;
	public Slider socialBar;


	public GameObject simsCharacter;


	// Use this for initialization
	void Start () {
		needs = (Needs) simsCharacter.GetComponent ("Needs");
	}
	
	// Update is called once per frame
	void Update () {
		
		hungerBar.value = needs.hunger/100f;
		boredomBar.value = needs.boredom/100f;
		tirenessBar.value = needs.tireness/100f;
		socialBar.value = needs.social/100f;

		Debug.Log ("UI Boredom Value="+needs.boredom);
		Debug.Log ("UI Social Value="+needs.social);
		Debug.Log ("UI Tireness Value="+needs.tireness);
		Debug.Log ("UI Hunger Value="+needs.hunger);
	}
}
