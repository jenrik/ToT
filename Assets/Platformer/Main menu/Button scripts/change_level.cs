using UnityEngine;
using System.Collections;

public class change_level : MonoBehaviour {
	public string level;
	void OnMouseDown() {
		Application.LoadLevel(level);	
		Application.Quit();
	}
}
