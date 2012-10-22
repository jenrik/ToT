using UnityEngine;
using System.Collections;

public class Instructions_panel: MonoBehaviour {
	private GameObject camera;
	private Vector3 the_return;
	public Material start_glowing;
	public Material start;
	public float turnRate;
	private bool rotate = false;
	
	void Start() {
		camera = GameObject.Find("Main Camera");
    }
	
	void Update() {
		if(rotate & camera.transform.rotation.y < 0.0F)
		{
			camera.transform.RotateAround (Vector3.zero, Vector3.up, 90 * Time.deltaTime);
		}
		else
		{
			rotate = false;
		}
	}
	
	void OnMouseDown() {
		rotate = true;
    }
	
	void OnMouseEnter(){
		this.renderer.material = start_glowing;
	}
	
	void OnMouseExit(){
		this.renderer.material = start;
	}
}
