using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void OnGUI() {
		GUI.skin.label.fontSize = 40;

		// todo properly pluralize the word cubes for management types
		// and my pedantic 3rd grade teacher
		GUI.Label (
			new Rect (new Vector3 (300f, 75f), new Vector2(100000f, 100000f)), 
			"EAT ALL OF THE CUBES!!!! YOU HAVE EATEN " + CubeSpawner.numCubesEaten.ToString() + " CUBES!!!"
		);
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D> ().AddForce (new Vector2 (Input.GetAxis ("Horizontal") * 5f, 0f));
	}

	void OnCollisionEnter2D(Collision2D coll) {
		Destroy (coll.gameObject);
		CubeSpawner.numCubesEaten += 1;
	}
}
