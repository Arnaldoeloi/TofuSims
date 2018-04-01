using UnityEngine;
using System.Collections;
using RTS_Cam;
using System;

[RequireComponent(typeof(RTS_Camera))]
public class ActionsController : MonoBehaviour 
{
    
    private new Camera camera;
    public string interactiveObjectsTag="interactive";



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
					hit.transform.GetComponent<InteractiveElement>().execute();
				}
            }
        }
    }
}
