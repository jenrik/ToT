using UnityEngine;
using System.Collections;

public class jump : MonoBehaviour {
	public float jumpForce;
	public int time;
	private bool started = true;
	//Easter eggs FTW
	private bool active;
	public bool way;
	public float rotate;
	void Update () {
		if(started)		
		{
			StartCoroutine(Jump());
			started = false;
		}
		if(active){
			this.collider.enabled = false;
			transform.rigidbody.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;
			rotate = this.transform.rotation.x;
			if(rotate < -0.2705981F) way = true; else if(rotate > 0.2819582F) way = false; 
			if(way) {
				transform.Rotate(Vector3.up * Time.deltaTime * 100);
			} else {
				transform.Rotate(Vector3.down * Time.deltaTime * 100);
			}
		}
	}
	
	IEnumerator Jump() {
		if(active == false){
	        rigidbody.AddForce(Vector3.up * jumpForce);
			yield return new WaitForSeconds(time);
			StartCoroutine(Jump());
		} /*else {
			print ("test");
			transform.rigidbody.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
			yield return new WaitForSeconds(0.1F);
			float rotate = this.transform.rotation.x;
			//if(rotate > 45) transform.Rotate(Vector3.left * Time.deltaTime); else if(rotate < 135) transform.Rotate(Vector3.left * Time.deltaTime);
			this.transform.Rotate(Time.deltaTime*Vector3.right);
		}*/
    }
	
	void OnMouseDown() {
		this.gameObject.audio.Play();
		active = true;
	}
}
