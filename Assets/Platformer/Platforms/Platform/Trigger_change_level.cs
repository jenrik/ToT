using UnityEngine;
using System.Collections;

public class Trigger_change_level : MonoBehaviour {
	public string level;
	public string playerTag;
	void OnTriggerEnter(Collider other){
			if(other.gameObject.tag == playerTag) Application.LoadLevel(level);
	}
}
