using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioPlayerController : InteractiveElement {

	Animator animator;
	AudioSource vynil;
	AudioSource music;
	private float auxGoodForBoredom=0.0f;


	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		vynil = GetComponentsInChildren<AudioSource>()[0];
		music = GetComponentsInChildren<AudioSource>()[1];
		this.auxGoodForBoredom = goodForBoredom;
		goodForBoredom = 0.0f;
	}
	

	
	public override void execute(){

		if (animator.GetBool ("isPlaying")) { //se tiver tocando, parar
			goodForBoredom=0.0f;
			animator.SetBool ("isPlaying", false);
			Debug.Log ("animator.isPlaying="+animator.GetBool("isPlaying"));

			vynil.Stop ();
			music.Stop ();

		} else {
			goodForBoredom = auxGoodForBoredom;
			animator.SetBool ("isPlaying", true);
			Debug.Log ("animator.isPlaying="+animator.GetBool("isPlaying"));

			vynil.Play ();
			music.Play ();

		}
	}
}
