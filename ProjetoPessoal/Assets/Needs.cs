using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Security.Cryptography.X509Certificates;

public class Needs : MonoBehaviour {

	private float time = 0.0f;
	

	public float decayTime=0.1f;
	public float hunger=50f;
	public float tireness=50f;
	public float boredom=50f;
	public float social=50f;
	public float bathroom=100f;
	public float shower=100f;

	public float minDecayLevelperTime = 0f;
	public float maxDecayLevelperTime = 10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;

		if (time >= decayTime) {
			time = time - decayTime;
			decayRandom();
			//Debug.Log ("Hunger: "+hunger);
		}

	}

	void decayRandom(){

		if (hunger >= 100.0f) {
			hunger = 100.0f;
		} else if (hunger <= 0) {
			hunger = 0f;
		}


		if (boredom >= 100.0f) {
			boredom = 100.0f;
		} else if (social <= 0) {
			boredom = 0f;
		}

		if (social >= 100.0f) {
			social = 100.0f;
		} else if (social <= 0) {
			social = 0f;
		}

		if (tireness >= 100.0f) {
			tireness = 100.0f;
		} else if (tireness <= 0) {
			tireness = 0f;
		}

		if (bathroom >= 100.0f) {
			bathroom = 100.0f;
		} else if (bathroom <= 0) {
			bathroom = 0f;
		}
			
		if (shower >= 100.0f) {
			shower = 100.0f;
		} else if (shower <= 0) {
			shower = 0f;
		}


		hunger -= Random.Range (minDecayLevelperTime, maxDecayLevelperTime);
		boredom -= Random.Range (minDecayLevelperTime, maxDecayLevelperTime);
		social -= Random.Range (minDecayLevelperTime, maxDecayLevelperTime);
		tireness -= Random.Range (minDecayLevelperTime, maxDecayLevelperTime);
		bathroom -= Random.Range (minDecayLevelperTime, maxDecayLevelperTime);
		shower -= Random.Range (minDecayLevelperTime, maxDecayLevelperTime);
		

	}
}
