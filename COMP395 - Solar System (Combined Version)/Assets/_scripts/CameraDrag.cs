using UnityEngine;
using System.Collections;

public class CameraDrag : MonoBehaviour
{
	//Instances
//	public float dragSpeed = 2;
//	private Vector3 dragOrigin; 
	public float speed;


	void Start()
	{
		//Referrencing to the component in unity
		//		GetComponent<Camera> ();
	}

	//update is called per frame
	void Update()
	{
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
//			Vector3 move = new Vector3 (position.x * dragSpeed, 0, position.y * dragSpeed);
//		}
//		//Conditional - to drag camera by clicking the left mouse button
//		if (Input.GetMouseButton (0)) 
//		{
//			transform.position.x -= Input.GetAxis ("Mouse X") * speed * Time.deltaTime;
//			transform.position.y -= Input.GetAxis ("Mouse Y") * speed * Time.deltaTime;
//		}
	}
}
