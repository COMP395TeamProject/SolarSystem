using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Collections.Generic;

public class CameraControl : MonoBehaviour
{
    public float zoomSpeed = 1;
    public float dragSpeed = 1;
    private Vector3 dragOrigin;


    public static CameraControl control;
    public bool planetSelected;
    public List<GameObject> planets;
    //public Camera camera;
    public float speed;
    public float planetSpeedMultiplier = 1;

    Vector3 cameraOriginPosition;
    Quaternion cameraOriginRotation;

    GameObject planet;
    private Vector3 offset;
    Vector3 Pos;

    public int zoom = 20;
    public int normal = 60;
    public float smooth = 5f;
    //private bool isZoomed = false;

    // Use this for initialization
    void Start()
    {
        cameraOriginPosition = this.gameObject.GetComponent<Transform>().position;
        cameraOriginRotation = this.gameObject.GetComponent<Transform>().rotation;
        planetSelected = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) /*&& Input.GetKey(KeyCode.Space)*/)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                print(hit.transform.name);

                foreach (GameObject p in planets)
                {
                    if (hit.transform.name.Equals(p.gameObject.name))
                    {
                        planet = p;

                        float planetX, planetZ;

                        if (planet.transform.position.x >= 0)
                            planetX = 1;
                        else
                            planetX = -1;

                        if (planet.transform.position.z >= 0)
                            planetZ = 1;
                        else
                            planetZ = -1;

                        Vector3 offset2 = new Vector3(planetX * 4, 0, planetZ * 4);
                        transform.position = planet.transform.position + offset2;// * (1.2f);
                        speed = planet.GetComponent<Rotate>().OrbitSpeed;
                        //print(planet.gameObject.name + ": " + Vector3.Distance(transform.position, planet.transform.position));
                        planetSelected = true;
                        transform.rotation = Quaternion.LookRotation(planet.transform.position - transform.position);
                        break;
                    }
                }
            }
            else
            {
                planetSelected = false;
                transform.position = cameraOriginPosition;
                transform.rotation = cameraOriginRotation;
            }
        }
        
        if (planetSelected)
        {
            transform.RotateAround(Vector3.zero, Vector3.up, speed * Time.deltaTime * planetSpeedMultiplier);

            Debug.DrawLine(transform.position, planet.transform.position);
        }
        else
        {
            
        }

        //Zooming In and Out:
        //conditional - "zoom in"
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - zoomSpeed, transform.position.z + zoomSpeed);
        }
        //conditional - "zoom out"
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + zoomSpeed, transform.position.z - zoomSpeed);
        }

        //Dragging Camera:
        //Conditional - mouse button has stopped being held down, so then it stops dragging the camera
        if (Input.GetMouseButtonDown(0))
        {
            dragOrigin = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        }
        //Conditional - mouse button is held down to drag the camera around
        if (Input.GetMouseButton(0))
        {
            Vector3 position = Camera.main.ScreenToViewportPoint(Input.mousePosition) - dragOrigin;
            Vector3 move = new Vector3(transform.position.x + position.x * dragSpeed, transform.position.y, transform.position.z);
            transform.position = move;
        }

        //print(Vector3.Distance(transform.position, planet.transform.position));
    }

    public void ChangeSpeed(float value)
    {
        planetSpeedMultiplier = value;
    }
}