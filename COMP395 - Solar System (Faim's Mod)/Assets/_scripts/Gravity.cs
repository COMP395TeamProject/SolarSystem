using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour {

	public float G = 1;

	public float StartingThrust = 14;
	public Rigidbody rb;



	void Start() {
		rb = GetComponent<Rigidbody>();
		rb.AddForce(transform.forward * StartingThrust);
		Debug.Log (StartingThrust);
	}

	//F = (G x m1 x m2) / r^2 
	void FixedUpdate() {
		foreach (GameObject g in GameObject.FindGameObjectsWithTag("Planet")) {
			Vector3 v3 = g.transform.position-this.transform.position;
			float distance = Vector3.Distance (this.transform.position, g.transform.position);
			float f = G * rb.mass * g.GetComponent<Rigidbody> ().mass / (distance * distance);
			rb.AddForce(v3 * f);
		}
	}
}
