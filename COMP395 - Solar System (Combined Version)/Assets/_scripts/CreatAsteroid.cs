using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatAsteroid : MonoBehaviour {

	public GameObject Asteroid;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		Ray cameraRay = Camera.main.ScreenPointToRay (Input.mousePosition);

		if (Input.GetMouseButtonDown (1)) {
			if(Physics.Raycast(cameraRay, out hit))
			{
				Instantiate(Asteroid, new Vector3(hit.point.x, 0, hit.point.z), Quaternion.identity);
			}
		} else if (Input.GetMouseButtonUp (1)) {
			if(Physics.Raycast(cameraRay, out hit))
			{
				//Debug.Log ("Hit: " + hit.point);
			}
		}
	}
}
