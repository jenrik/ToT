using UnityEngine;
using System.Collections;

public class player_animation_handler : MonoBehaviour {
	public Material[] rightWalk;
	public Material[] leftWalk;
	public Material[] jump;
	public Material standing;
	public float timer;
	private string currentAnimation;
	
	private bool started;
	private bool mayStand = true;
	void Update () {
		if(started == false){
			StartCoroutine(animation());
			started = true;
		}
		float horizontal = Input.GetAxis("Horizontal");
		if(Input.GetButtonUp("Jump")){
			mayStand = false;
			currentAnimation = "jumping";
		} else if(horizontal < 0.0F){
			currentAnimation = "left";
		} else if(horizontal > 0.0F){
			currentAnimation = "right";
		} else if(horizontal == 0.0F & mayStand){
			currentAnimation = "standing";
		}
	}
	
	IEnumerator animation(){
		if(currentAnimation == "jumping"){
			mayStand = true;
			for(int i = 0; i < jump.Length; i++){
				if(currentAnimation != "jumping") break;
				this.renderer.material = jump[i];
				yield return new WaitForSeconds(timer/10);
			}
		} else if(currentAnimation == "right"){
			for(int i = 0; i < rightWalk.Length; i++){
				if(currentAnimation != "right") break;
				this.renderer.material = rightWalk[i];
				yield return new WaitForSeconds(timer);
			}
		} else if(currentAnimation == "left"){
			for(int i = 0; i < leftWalk.Length; i++){
				if(currentAnimation != "left") break;
				this.renderer.material = leftWalk[i];
				yield return new WaitForSeconds(timer);
			}
		} else if(currentAnimation == "standing"){
			this.renderer.material = standing;
			yield return new WaitForSeconds(timer);
		} else yield return new WaitForSeconds(0.005F);
		StartCoroutine(animation());
	}
}
