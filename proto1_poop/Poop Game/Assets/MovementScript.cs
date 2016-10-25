using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour {

	private Rigidbody2D rigid2D;

	// Use this for initialization
	void Start () {
		rigid2D = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.RightArrow)) {
			rigid2D.AddForce(new Vector2 (10f, 0f));
		}
		if (Input.GetKey(KeyCode.LeftArrow)) {
			rigid2D.AddForce(new Vector2 (-10f, 0f));
		}
		if (Input.GetKey(KeyCode.DownArrow)) {
			rigid2D.AddForce(new Vector2 (0f, -10f));
		}
		if (Input.GetKey(KeyCode.UpArrow)) {
			rigid2D.AddForce(new Vector2 (0f, 10f));
		}
	}
}
