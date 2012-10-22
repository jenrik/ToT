using UnityEngine;
using System.Collections;

public class qustion_mark_button : MonoBehaviour {
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
		if(rotate & camera.transform.rotation.y > -0.7071066F)
		{
			camera.transform.RotateAround (Vector3.zero, Vector3.up, -90 * Time.deltaTime);
		}
		else
		{
			rotate = false;
		}
		//Vector3.RotateTowards(new Vector3(0,0,0), new Vector3(0,90,0), Mathf.Deg2Rad*turnRate*Time.deltaTime, 1);
		//camera.transform.rotation = Quaternion.LookRotation(the_return);
	}
	
	void OnMouseDown() {
		rotate = true;
        //Application.LoadLevel("SomeLevel");
    }
	
	void OnMouseEnter(){
		this.renderer.material = start_glowing;
	}
	
	void OnMouseExit(){
		this.renderer.material = start;
	}
}
