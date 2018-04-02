using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FridgeElement : InteractiveElement {

	public Food[] foods = new Food[10];
	public Food applePrefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public override void execute ()
	{
		Debug.Log (foods.Length);

		foreach (Food food in foods) {
			
		}
	}

	public void addApple(){
		//foods. = applePrefab;
	}
}
