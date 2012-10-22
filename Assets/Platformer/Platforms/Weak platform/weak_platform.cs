using UnityEngine;
using System.Collections;

public class weak_platform : MonoBehaviour {
	public float time;
	public float respawnTime;
	private bool started = true;
	public GameObject imageObject;
	public Material image1;
	public Material image2;
	public Material image3;
	public Material image4;
	public Material image5;
	private int currentImage = 1;
	
	void OnTriggerEnter (Collider collision) {
		if(started)		
		{
			StartCoroutine(Jump());
			started = false;
		}
	}
	IEnumerator Jump() {
		if(currentImage == 1) {
			imageObject.renderer.material = image1;
		} else if(currentImage == 2){
			imageObject.renderer.material = image2;
		} else if(currentImage == 3){
			imageObject.renderer.material = image3;
		} else if(currentImage == 4){
			imageObject.renderer.material = image4;
		} else if(currentImage == 5){
			imageObject.renderer.material = image5;
		} else if(currentImage == 6){
			imageObject.renderer.enabled = false;
			this.transform.parent.gameObject.active = false;
			yield return new WaitForSeconds(respawnTime);
			imageObject.renderer.enabled = true;
			this.transform.parent.gameObject.active = true;
			imageObject.renderer.material = image1;
			currentImage = 1;
			started = true;
		}
		yield return new WaitForSeconds(time);
		currentImage++;
		print (currentImage);
		if(started == false) StartCoroutine(Jump());
    }
}
