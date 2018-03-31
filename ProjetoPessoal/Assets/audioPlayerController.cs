using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioPlayerController : MonoBehaviour {

	Animator animator;
	AudioSource vynil;
	AudioSource music;


	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		vynil = GetComponentsInChildren<AudioSource>()[0];
		music = GetComponentsInChildren<AudioSource>()[1];
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("f")) {
			Debug.Log ("animator.isPlaying="+animator.GetBool("isPlaying"));
			Debug.Log ("Apertou F");

			if (animator.GetBool ("isPlaying")) {
				animator.SetBool ("isPlaying", false);
				Debug.Log ("animator.isPlaying="+animator.GetBool("isPlaying"));

				vynil.Stop ();
				music.Stop ();

			} else {
				animator.SetBool ("isPlaying", true);
				Debug.Log ("animator.isPlaying="+animator.GetBool("isPlaying"));

				vynil.Play ();
				music.Play ();

			}
		}

	}
}
