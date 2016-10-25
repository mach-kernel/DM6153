using UnityEngine;
using System.Collections;

public class GameMarshaller : MonoBehaviour {

	private static float timeLeft;
	private GameObject toilet;
	private GameObject camera;

	void Awake() {
		camera = GameObject.Find ("Main Camera").gameObject;
		PoopTimer.blinkWait = 2.0f;
		timeLeft = 30f;
		for (int i = 0; i < Random.Range (0, 500); ++i) {
			ObstacleFactory ();
		}
		toilet = Instantiate (GameObject.Find ("ToiletSprite"));
		toilet.GetComponent<SpriteRenderer> ().enabled = true;
	}

	void OnGUI() {
		GUI.skin.label.fontSize = 40;

		// No interpolation in this runtime + sprintf
		GUI.Label (
			new Rect (GameObject.Find ("PoopSprite").transform.position + new Vector3 (300f, 75f), new Vector2(100000f, 100000f)), 
			"YOU HAVE TO SHIT! GET TO THE TOILET BEFORE IT'S TOO LATE: " + timeLeft.ToString("F2") + "s"
		);

		if (timeLeft < 10f) {
			GUI.skin.label.fontStyle = FontStyle.BoldAndItalic;
		}
	}
		

	// Use this for initialization
	void Start () {
		StartCoroutine (toiletRoutine ());
	}

	void ObstacleFactory() {
		var newObject = Instantiate (GameObject.Find ("ObstacleSprite")).gameObject;
		newObject.GetComponent<SpriteRenderer> ().enabled = true;
		newObject.transform.position = randomPosition ();
	}

	Vector3 randomPosition() {
		var cBounds = camera.GetComponent<CameraBounds> ();
		return new Vector3 (Random.Range (-cBounds.max_x, cBounds.max_x), Random.Range (-cBounds.max_y, cBounds.max_y), 0f);
	}

	private IEnumerator toiletRoutine() {
		while (true) {
			toilet.transform.position = randomPosition ();
			yield return new WaitForSeconds (5.0f);
		}
	}

	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;

		if (timeLeft < 20) {
			PoopTimer.blinkWait = 1f;
		}
		if (timeLeft < 15) {
			PoopTimer.blinkWait = 0.5f;
		}
		if (timeLeft < 10) {
			PoopTimer.blinkWait = 0.25f;
		}
		if (timeLeft < 5) {
			PoopTimer.blinkWait = 0.10f;
		}
		if (timeLeft < 2) {
			PoopTimer.blinkWait = 0.05f;
		}
		if (timeLeft < 0) {
			UnityEngine.SceneManagement.SceneManager.LoadScene("Lose");
		}
	}
		
}
