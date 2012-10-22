using UnityEngine;
using System.Collections;

public class dance : MonoBehaviour {	
	//Easter eggs FTW
	private bool active;
	void Update () {
		print (active);
		if(active) print ("test");
	}
	
	void OnMouseDown() {
		print ("test easter egg");
		active = true;	
	}
}
