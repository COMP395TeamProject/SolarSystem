using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class CameraController : MonoBehaviour 
{
	//Instances
//	public Camera camera;
//	public Slider zoom;
//	public float dragSpeed = 2;
//	private Vector3 dragOrigin; 


	void Start()
	{
		//Referrencing to the component in unity
//		GetComponent<Camera> ();
	}

	//update is called per frame
	void Update()
	{
		//Zooming In and Out:
		//conditional - "zoom in"
		if (Input.GetAxis ("Mouse ScrollWheel") > 0) 
		{
			//Referrencing to the component in unity
			GetComponent<Camera>().fieldOfView--; //decrementing the "fieldOfView" so we can look at the scene closer
		}
		//conditional - "zoom out"
		if (Input.GetAxis ("Mouse ScrollWheel") < 0) 
		{
			//Referrencing to the component in unity
			GetComponent<Camera>().fieldOfView++; //incrementing the "fieldOfView" so we can look away from the scene
		}

//		//Dragging Camera:
//		//Conditional - mouse button has stopped being held down, so then it stops dragging the camera
//		if (Input.GetMouseButtonDown (0)) 
//		{
//			dragOrigin = Input.mousePosition;
//			return;
//		}
//		//Conditional - mouse button is held down to drag the camera around
//		if (!Input.GetMouseButtonDown (0)) 
//		{
//			Vector3 position = Camera.main.ScreenToViewportPoint (Input.mousePosition - dragOrigin);
//			Vector3 move = new Vector3 (position.x * dragSpeed, position.z * dragSpeed, position.y * dragSpeed);
//		}
	}

	//Methods
//	public void ResetCameraPosition()
//	{
//		camera.transform (0, 100, -100);
//		camera.fieldOfView (60);
//	}

//	public void zoom(float value)
//	{
//		GetComponent<Camera> ().fieldOfView = value;
//	}
}
