using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class CameraController : MonoBehaviour 
{
	//Instances
//	public Camera camera;
//	public Slider zoom;

	void Start()
	{
		//Referrencing to the component in unity
//		GetComponent<Camera> ();
	}

	//update is called per frame
	void Update()
	{
		//conditional to "zoom in"
		if (Input.GetAxis ("Mouse ScrollWheel") > 0) 
		{
			//Referrencing to the component in unity
			GetComponent<Camera>().fieldOfView--; //decrementing the "fieldOfView" so we can look at the scene closer
		}

		//conditional to "zoom out"
		if (Input.GetAxis ("Mouse ScrollWheel") < 0) 
		{
			//Referrencing to the component in unity
			GetComponent<Camera>().fieldOfView++; //incrementing the "fieldOfView" so we can look away from the scene
		}
	}

	//Methods
//	public void ResetCameraPosition()
//	{
//		camera.transform (0, 100, -100);
//		camera.fieldOfView (60);
//	}
}
