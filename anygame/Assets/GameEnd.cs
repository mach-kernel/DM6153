using UnityEngine;
using System.Collections;

public class GameEnd : MonoBehaviour {


	void OnTriggerEnter2D(Collider2D other) {
		if (other.name == "Sphere") {
			if (CubeSpawner.numCubesEaten == CubeSpawner.numCubesSpawned) {
				Application.LoadLevel ("Win");
			}
			CubeSpawner.numCubesEaten = 0;
			Application.LoadLevel (Application.loadedLevel);
		}
	}
}
