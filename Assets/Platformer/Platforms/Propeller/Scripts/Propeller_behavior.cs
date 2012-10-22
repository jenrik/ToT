using UnityEngine;
using System.Collections;

public class Propeller_behavior : MonoBehaviour {
	public float force = 100.0F;
	void OnTriggerStay(Collider other) {
        if (other.attachedRigidbody)
            other.attachedRigidbody.AddForce(Vector3.up * force);
        
    }
}
