using UnityEngine;
using System.Collections;

public class Platform_generator : MonoBehaviour {
	private Transform player;
	public Transform platform;
	public int platformChance;
	public Transform conveyor;
	public int conveyorChance;
	public Transform spikes;
	public int spikesChance;
	public Transform cracking;
	public int crackingChance;
	public Transform propeller;
	public int propellerChance;
	public Transform candy;
	public int candyChance;
	public int numberOfCubes;
	public int sizeX;
	public int sizeY;
	public int spreadX;
	public int spreadY;
	private Object[] cubes;
	public float time;
	void Start() {
		generat_level();
		
	}
	
	void generat_level() {
		//check for valid input
		player = transform.Find("Side scroller player");
		if(platform == null) Debug.LogError("Missing normal platform object");
		if(conveyor == null) Debug.LogError("Missing conveyor platform object");
		if(spikes == null) Debug.LogError("Missing spike platform object");
		if(cracking == null) Debug.LogError("Missing cracking platform object");
		if(propeller == null) Debug.LogError("Missing propeller platform object");
		if(conveyorChance == null) Debug.LogError("Missing propeller platform spawn chance object");
		if(spikesChance == null) Debug.LogError("Missing propeller platform spawn chance object");
		if(crackingChance == null) Debug.LogError("Missing propeller platform spawn chance object");
		if(propellerChance == null) Debug.LogError("Missing propeller platform spawn chance object");
		if(platformChance == null) Debug.LogError("Missing propeller platform spawn chance object");
		//check end
		cubes = new Object[numberOfCubes];
		Quaternion rotation = Quaternion.Euler(0, 180, 0);
		Quaternion rotation2 = Quaternion.Euler(0, 180, 180);
		for(int i = 0; i < numberOfCubes; i++) {
			int randomX = Random.Range(0, sizeX);
			int randomY = Random.Range(0, sizeY);
			GameObject plane = GameObject.Find(randomX + " " + randomY);
			if(plane.ToString() == "null"){
				int x = spreadX * randomX;
				int y = spreadY * randomY;
				if (randomY  % 2 == 1){
					x += spreadX / 2;
				}
				int random = Random.Range(0, platformChance + conveyorChance + spikesChance + crackingChance + propellerChance + candyChance);
				Transform thing = platform;
				if(random <= platformChance){
					cubes[i] = Instantiate(platform, new Vector3(x - sizeX / 2 , y - sizeY / 2, 0), rotation);
				} else if(random >= conveyorChance & random <= platformChance + conveyorChance) {
					cubes[i] = Instantiate(conveyor, new Vector3(x - sizeX / 2 , y - sizeY / 2, 0), rotation);
				} else if(random >= spikesChance & random <= platformChance + conveyorChance + spikesChance) {
					cubes[i] = Instantiate(spikes, new Vector3(x - sizeX / 2 + 0.145F, y - sizeY / 2 + 0.23F, 0), rotation); 
				} else if(random >= crackingChance & random <= platformChance + conveyorChance + spikesChance + crackingChance) {
					cubes[i] = Instantiate(cracking, new Vector3(x - sizeX / 2 + 0.068F, y - sizeY / 2 + 0.55F, 0), rotation);
				} else if(random >= propellerChance & random <= platformChance + conveyorChance + spikesChance + crackingChance + propellerChance) {
					cubes[i] = Instantiate(propeller, new Vector3(x - sizeX / 2 , y - sizeY / 2 + 0.45F, 0), rotation2);
				}else if(random >= propellerChance & random <= platformChance + conveyorChance + spikesChance + crackingChance + propellerChance + candyChance) {
					cubes[i] = Instantiate(candy, new Vector3(x - sizeX / 2 , y - sizeY / 2, 0), rotation);
				}
				cubes[i].name = randomX + " " + randomY;
			} else i--;
		}
	}
	private bool OneTime = true;
	void Update () {
		if(OneTime){
			this.transform.position = new Vector3(0, 0, 0);
			OneTime = false;
		}
	}
	private bool gameOver;
	public Transform gameOverText;
	void OnGUI(){
		float timeLeft = time - Time.time;
		GUI.Label(new Rect(10, 50, 100, 20), "Time left: " + Mathf.Floor(timeLeft).ToString());
		if(timeLeft < 0.0F) gameOver = true;
		print (gameOver);
		//if(gameOver) gameOverText.active = true;
	}
}
