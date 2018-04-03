using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelevisionController : InteractiveElement {

	public bool isTurnedOn=false;
	private AudioSource[] programasSons;
	private Material tvScreenMaterial;
	private float auxGoodForBoredom;
	public float goodForBoredomWhenTurnedOff=0.0f; //for paintings, for example


	// Use this for initialization
	void Start () {
		programasSons = this.GetComponentsInChildren<AudioSource> ();
		tvScreenMaterial=this.GetComponentInChildren<MeshRenderer> ().materials[1];
		auxGoodForBoredom = this.goodForBoredom;
		if (!isTurnedOn) {
			this.goodForBoredom = goodForBoredomWhenTurnedOff;
		} else {
			this.goodForBoredom = auxGoodForBoredom;
		}
	}

	void Update(){
		if(isTurnedOn){

			//tvScreenMaterial.SetColor("_Color", Color.red);
			goodForBoredom=auxGoodForBoredom;
			float emission = Mathf.PingPong (Time.time*10, 4.0f);
			Color baseColor = Color.yellow; //Replace this with whatever you want for your base color at emission level '1'

			Color finalColor = baseColor * Mathf.LinearToGammaSpace (emission);

			tvScreenMaterial.SetColor ("_EmissionColor", finalColor);

		}
		//tvScreenMaterial.materials [1].Set;

	}


	public override void execute(){

		//SE ESTIVER LIGADA, DESLIGAR
		if (isTurnedOn) {
			
			isTurnedOn = false;
			this.goodForBoredom = goodForBoredomWhenTurnedOff;
			foreach (AudioSource programa in programasSons) {
				programa.Stop();
			}
			tvScreenMaterial.SetColor ("_EmissionColor", Color.black);
		} else { //SE ESTIVER DESLIGADA, LIGAR
			isTurnedOn = true;

			int n = Random.Range (0, programasSons.Length);
			programasSons [n].Play ();

		}
	}

	/*
			bool alreadyPlaying = false;
			foreach (AudioSource programa in programasSons) {
				if (programa.isPlaying) {
					alreadyPlaying = true;
				}
			}
			if (!alreadyPlaying) {
				int n = Random.Range (0, programasSons.Length);
				programasSons [n].Play ();
			}
	*/
}
