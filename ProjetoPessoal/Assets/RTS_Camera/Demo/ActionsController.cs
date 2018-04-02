using UnityEngine;
using System.Collections;
using RTS_Cam;
using System;

[RequireComponent(typeof(RTS_Camera))]
public class ActionsController : MonoBehaviour 
{
    
    private Camera camera;
    public string interactiveObjectsTag="interactive";
	public Needs mainCharacterNeeds;
	public Canvas menuExecutedWhenInteractivePrefab;


    private void Start()
    {
    
        camera = gameObject.GetComponent<Camera>();
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

			if(Physics.Raycast(ray, out hit, 100))
            {
				
				Debug.Log(hit.transform.tag);
				if (hit.transform.CompareTag(interactiveObjectsTag)){
                    //cam.SetTarget(hit.transform);
					Instantiate(menuExecutedWhenInteractivePrefab,hit.transform.position, new Quaternion(0,0,0,0));
					if(hit.transform.GetComponent<Food>() && hit.transform.GetComponent<Food>()!=null){
						mainCharacterNeeds.tireness += hit.transform.GetComponent<Food> ().goodForTireness;
						mainCharacterNeeds.bathroom += hit.transform.GetComponent<Food> ().goodForBathroom;
						mainCharacterNeeds.hunger += hit.transform.GetComponent<Food> ().goodForHunger;
					}

					hit.transform.GetComponent<InteractiveElement>().execute();

				}
            }
        }
    }
}
