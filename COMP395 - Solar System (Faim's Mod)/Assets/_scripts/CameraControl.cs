using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class CameraControl : MonoBehaviour {

	public static CameraControl control;
	public static int planetSelected;
	public GameObject planet1;
	public GameObject planet2;
	public Camera camera;
    public float speed;

	GameObject planet;
	private Vector3 offset;
	Vector3 Pos;

	public int zoom = 20;
	public int normal = 60;
	public float smooth = 5f;	
	private bool isZoomed = false;	

	// Use this for initialization
	void Start () 
	{
        //offset = transform.position;
        offset = new Vector3(transform.position.x, transform.position.y - 68.4f, transform.position.z + 85);
        transform.rotation = Quaternion.AngleAxis(0, Vector3.up);
        transform.position = planet1.transform.position + offset;
		planet = planet1;
		planetSelected = 1;
        speed = 365 / planet.GetComponent<Rotate>().OrbitSpeed;
        //print(speed);
	}

	// Update is called once per frame
	void Update () 
	{
		if(Input.GetMouseButtonDown(1))
		{
			isZoomed = !isZoomed;
		}
		
		if(isZoomed == true)
		{
			camera.fieldOfView = Mathf.Lerp(camera.fieldOfView, zoom, Time.deltaTime * smooth);
			//Camera.main.fieldOfView = Mathf.Lerp(Camera.current.fieldOfView, zoom, Time.deltaTime * smooth);
			//Camera.current.fieldOfView = Mathf.Lerp(Camera.current.fieldOfView, zoom, Time.deltaTime * smooth);
		}
		else
		{
			camera.fieldOfView = Mathf.Lerp(camera.fieldOfView, normal, Time.deltaTime * smooth);
		}


		//Camera position
		if(Input.GetKey(KeyCode.Alpha1))
		{
            transform.position = planet1.transform.position + offset;
			planet = planet1;
            speed = planet.GetComponent<Rotate>().OrbitSpeed;
            print("p1 speed: " + speed);
            planetSelected = 1;
		}
		if(Input.GetKey(KeyCode.Alpha2))
		{
            transform.position = planet2.transform.position + offset;
			planet = planet2;
            speed = planet.GetComponent<Rotate>().OrbitSpeed;
            print("p2 speed: " + speed);
            planetSelected = 2;
		}

		/*//Camera zoom
		if(Input.GetKey(KeyCode.Q))
		{
			Pos = transform.position - offset;
			Pos.z += 1f * Time.deltaTime;			
			transform.position = Pos;
		}
		if(Input.GetKey(KeyCode.A))
		{
			Pos.z = transform.position.z - offset.z;
			Pos.z += 1f * Time.deltaTime;			
			transform.position = Pos;
		}*/

		//transform.position = planet.transform.position + offset;
        transform.RotateAround(Vector3.zero, Vector3.up, speed * Time.deltaTime);
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(planet.transform.position - transform.position), speed * Time.deltaTime);

        //print(Vector3.Distance(transform.position, planet.transform.position));
    }
    

}
