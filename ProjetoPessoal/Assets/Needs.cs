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
			Debug.Log ("Hunger: "+hunger);
		}

	}

	void decayRandom(){
		
		hunger -= Random.Range (minDecayLevelperTime, maxDecayLevelperTime);
		boredom -= Random.Range (minDecayLevelperTime, maxDecayLevelperTime);
		social -= Random.Range (minDecayLevelperTime, maxDecayLevelperTime);
		tireness -= Random.Range (minDecayLevelperTime, maxDecayLevelperTime);


	}
}
