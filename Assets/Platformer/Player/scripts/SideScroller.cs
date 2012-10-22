using UnityEngine;
using System.Collections;

public class SideScroller : MonoBehaviour {
	public float speed = 10.0F;
	public float rotationSpeed = 100.0F;
	public float jump = 100.0F;
	private bool jumpAllow = true;
	private float spawnX = 0.0F;
	private float spawnY = 0.0F;
	private float spawnZ = 0.0F;
	private float controller;
	private int point;
	public AudioClip jumpSound;
	public AudioClip landSound;
	public GUIStyle scoreStyle;
	void Start () {
		//Instantiate(gameObject, new Vector3(spawnX, spawnY, spawnZ), Quaternion.identity);
		spawnX = transform.position.x;
		spawnY = transform.position.y;
		spawnZ = transform.position.z;
	}
	
	void Update () {
		float translation = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(translation, 0, 0);
		//rigidbody.AddForce(-Vector3.left * translation);
		//rigidbody.velocity = new Vector3(transform.right.x * translation, rigidbody.velocity.y, rigidbody.velocity.z);
		if(Input.GetButtonDown("Jump") & jumpAllow)
		{
			audio.PlayOneShot(jumpSound);
			rigidbody.AddForce(Vector3.up * jump);
		}
    }
	
	void OnCollisionStay(Collision collisionInfo) {
		if(collisionInfo.collider.tag == "platform")
		{
			jumpAllow = true;
		}
	}
	
	void OnCollisionExit()
	{
		jumpAllow = false;
	}
	
	void OnGUI() {
		GUI.Label(new Rect(10, 40, 100, 20), "Score: " + point, scoreStyle);
	}
	
	public void addPoint() {
		point++;
	}
		
	void OnCollisionEnter(){
		audio.PlayOneShot(landSound);	
	}
}
