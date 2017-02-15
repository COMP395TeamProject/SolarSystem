using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour 
{
	//Public Instances
    public float PlanetRotateSpeed = -25.0f;
    public float OrbitSpeed = 20.0f;

    // Update is called once per frame
    void Update ()
    {
        // planet to spin on it's own axis
        transform.Rotate(transform.up * PlanetRotateSpeed * Time.deltaTime);

        // planet to travel along a path that rotates around the sun
        transform.RotateAround(Vector3.zero, Vector3.up, OrbitSpeed * Time.deltaTime);   
    }
}
