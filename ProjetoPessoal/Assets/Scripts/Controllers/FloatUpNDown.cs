﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatUpNDown : MonoBehaviour {



	public float degreesPerSecond = 15.0f;
	public float amplitude = 0.5f;
	public float frequency = 1f;

	Vector3 posOffset = new Vector3();
	Vector3 tempPos= new Vector3();

	// Use this for initialization
	void Start () {
		posOffset = transform.position;
	}
	
	// Update is called once per frame
	void Update () {


		tempPos = posOffset; //posição atual
		tempPos.y+=Mathf.Sin(Time.fixedTime*Mathf.PI*frequency)*amplitude;
		Vector3 position = transform.position;
		position [1] = tempPos.y;
		transform.position = position;
	}
}
