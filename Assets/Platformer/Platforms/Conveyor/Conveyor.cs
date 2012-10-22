using UnityEngine;
using System.Collections;

public class Conveyor : MonoBehaviour {
	public float speed = 10.0F;
	void OnTriggerStay(Collider other) {
        if (other.attachedRigidbody){
			//other.attachedRigidbody.AddForce(Vector3.up * 10);
            other.attachedRigidbody.AddForce(Vector3.left * speed);
		}
        
    }
}
