using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System.Security.Policy;

public class MoveToClickPosition : MonoBehaviour {
	NavMeshAgent agent;
	public GameObject markerPrefab;
	private Animator anim;



	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent> ();
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			RaycastHit hit;

			if (Physics.Raycast (Camera.main.ScreenPointToRay (Input.mousePosition), out hit, 100)) {
				agent.destination = hit.point;
				Instantiate (markerPrefab, hit.point, markerPrefab.transform.rotation);
			}
		}

		if (!pathComplete()) {
			anim.SetBool ("isMoving", true);
		} 
		if(pathComplete()){
			anim.SetBool ("isMoving", false);
		}

	}

	protected bool pathComplete()
	{
		if ( Vector3.Distance( agent.destination, agent.transform.position) <= agent.stoppingDistance)
		{
			if (!agent.hasPath || agent.velocity.sqrMagnitude == 0f)
			{
				return true;
			}
		}

		return false;
	}

}
