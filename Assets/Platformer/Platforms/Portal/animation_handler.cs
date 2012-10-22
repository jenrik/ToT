using UnityEngine;
using System.Collections;

public class animation_handler : MonoBehaviour {
	public Material[] images;
	public bool forwardAndBacward;
	public float timeInSeconds;
	private bool started = true;
	void Update () {
		if(started){
			StartCoroutine(animation());
			started = false;
		}
	}
	IEnumerator animation() {
		if(forwardAndBacward){
			while(true){
				for(int i = 0; i < images.Length;){
					this.renderer.material = images[i];
					yield return new WaitForSeconds (timeInSeconds);
					i++;
				}
				for(int i = images.Length; i > 0;){
					this.renderer.material = images[i-1];
					yield return new WaitForSeconds (timeInSeconds);
					i--;
				}
			}
		} else {
			while(true){
				for(int i = 0; i < images.Length;){
					this.renderer.material = images[i];
					yield return new WaitForSeconds (timeInSeconds);
					i++;
				}
			}
		}
	}
}
