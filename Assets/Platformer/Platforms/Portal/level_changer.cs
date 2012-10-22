using UnityEngine;
using System.Collections;

public class level_changer : MonoBehaviour {
	public string playerTag;
	public string level;
	void OnTriggerEnter(Collider other){
		if(other.transform.tag == playerTag){
			Application.LoadLevel(level);
		}
	}
}
