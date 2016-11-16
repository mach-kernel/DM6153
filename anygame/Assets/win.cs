using UnityEngine;
using System.Collections;

public class win : MonoBehaviour {

	void OnGUI() {
		GUI.skin.label.fontSize = 40;

		// todo properly pluralize the word cubes for management types
		// and my pedantic 3rd grade teacher
		GUI.Label (
			new Rect (new Vector3 (300f, 75f), new Vector2(100000f, 100000f)), 
			"you ate all the cubes and can now delete me. press space to close."
		);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			Application.Quit ();
		}
	}
}
