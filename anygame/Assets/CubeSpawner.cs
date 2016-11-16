using UnityEngine;
using System.Collections;

public class CubeSpawner : MonoBehaviour {

	public static int numCubesEaten = 0;
	public static int numCubesSpawned = 0; 

	// Use this for initialization
	void Start () {
		numCubesSpawned = Random.Range (0, 500);
		for (int i = 0; i < numCubesSpawned; ++i) {
			ObstacleFactory ();
		}
	}

	void ObstacleFactory() {
		var newObject = Instantiate (GameObject.Find ("HitMe")).gameObject;
		newObject.transform.position = randomPosition ();
	}

	Vector3 randomPosition() {
		return new Vector3 (Random.Range (-4f, 4f), Random.Range (-4f, 4f), 0f);
	}
}
