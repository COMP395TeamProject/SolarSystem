using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class CameraController : MonoBehaviour 
{
	//Instances
	public float zoomSpeed = 1;
	public float dragSpeed = 1;
	private Vector3 dragOrigin;


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
			transform.position = new Vector3(transform.position.x, transform.position.y -zoomSpeed, transform.position.z +zoomSpeed);
		}
		//conditional - "zoom out"
		if (Input.GetAxis ("Mouse ScrollWheel") < 0) 
		{
			transform.position = new Vector3(transform.position.x, transform.position.y +zoomSpeed, transform.position.z -zoomSpeed);
		}

		//Dragging Camera:
		//Conditional - mouse button has stopped being held down, so then it stops dragging the camera
		if (Input.GetMouseButtonDown (0)) 
		{
			dragOrigin = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		}
		//Conditional - mouse button is held down to drag the camera around
		if (Input.GetMouseButton (0)) 
		{
			Vector3 position = Camera.main.ScreenToViewportPoint (Input.mousePosition) - dragOrigin;
			Vector3 move = new Vector3 (transform.position.x + position.x * dragSpeed, transform.position.y, transform.position.z);
			transform.position = move;
		}
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
