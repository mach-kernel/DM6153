using UnityEngine;
using System.Collections;

public class YouLose : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	void OnGUI() {
		GUI.skin.label.fontSize = 40;

		// No interpolation in this runtime + sprintf
		GUI.Label (
			new Rect(new Vector3 (500f, 75f), new Vector2(100000f, 100000f)), 
			"YOU SHIT YOUR PANTS LOL SPACE TO PLAY AGAIN"
		);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Space)) {
			UnityEngine.SceneManagement.SceneManager.LoadScene ("MainScene");
		}
	}
}
