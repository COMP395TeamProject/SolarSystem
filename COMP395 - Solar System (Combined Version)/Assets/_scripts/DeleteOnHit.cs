using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteOnHit : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Planet") {
			Destroy (this.gameObject);
		}
	}
}
