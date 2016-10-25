using UnityEngine;
using System.Collections;

public class CameraBounds : MonoBehaviour {

	private BoxCollider2D boxCol2D;

	public float max_x;
	public float max_y;

	// Use this for initialization
	void Start () {
		max_y = 2f * Camera.main.orthographicSize;
		max_x = max_y * Camera.main.aspect;

		boxCol2D = GetComponent<BoxCollider2D> ();
		boxCol2D.size = new Vector3(max_x, max_y, 0f);

		// It pushes everything out!
		// boxCol2D.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
