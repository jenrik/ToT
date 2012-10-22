using UnityEngine;
using System.Collections;

public class Spike_behavior : MonoBehaviour {
	void OnTriggerStay(Collider other) {
		print(other.collider.tag);
        if (other.attachedRigidbody & other.collider.tag == "Player") {
			//other.transform.root.gameObject.rigidbody.velocity = Vector3.zero;
			//other.transform.root.gameObject.rigidbody.angularVelocity = Vector3.zero;
			//other.transform.root.transform.position = new Vector3(0.0F, 1.1F, -0.4F);
			Application.LoadLevel(Application.loadedLevel);
		}
    }
}
