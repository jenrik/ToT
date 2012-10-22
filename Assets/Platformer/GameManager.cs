using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public float spawnX = 0.0F;
	public float spawnY = 0.0F;
	private float spawnZ = 0.0F;
	
	void Start () {
		respawn ();
	}
	
	void Update () {
		print (Time.deltaTime);
	}
	
	void respawn() {
		//Instantiate(gameObject, new Vector3(spawnX, spawnY, spawnZ), Quaternion.identity);	
	}
}
