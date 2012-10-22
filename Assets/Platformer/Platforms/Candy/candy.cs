using UnityEngine;
using System.Collections;

public class candy : MonoBehaviour {
	private float bottom;
	public float height;
	public float speed;
	private bool way;
	
	SideScroller s = new SideScroller ();
	private GameObject player;
	
	void Start(){
		player = GameObject.Find("Side scroller player");
		s = player.GetComponent<SideScroller>();
		bottom = this.transform.position.y;
		height += this.transform.position.y;
	}
	
	void Update () {
		if(this.transform.position.y > height)
		{
			way = false;
		}
		if(this.transform.position.y < bottom)
		{
			way = true;
		}
		if(way)
		{
			transform.Translate(new Vector3(0, 0, -speed));
		}
		else
		{
			transform.Translate(new Vector3(0, 0, speed));
		}
		
	}
	
	void OnTriggerEnter() {
		this.gameObject.active = false;
		s.addPoint();
	}
}
