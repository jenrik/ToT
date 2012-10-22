using UnityEngine;
using System.Collections;

public class mute_sound : MonoBehaviour {
	private bool isMuted = true;
	void OnGUI() { 
		if(isMuted)
		{
        	if (GUI.Button(new Rect(10, 10, 50, 30), "Mute")) {
           		this.gameObject.audio.enabled = false;
				isMuted = false;
			}
		} else {
			if (GUI.Button(new Rect(10, 10, 60, 30), "Unmute")) {
           		this.gameObject.audio.enabled = true;
				isMuted = true;
			}
		}
    }
}
