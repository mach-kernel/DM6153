using UnityEngine;
using System.Collections;

public class PoopTimer : MonoBehaviour {

	public static float blinkWait = 2f;
	private SpriteRenderer injectedRenderer;

	// Use this for initialization
	void Start () {
		injectedRenderer = this.GetComponent<SpriteRenderer> ();
		StartCoroutine (blinkRoutine());
	}
	
	// Update is called once per frame
	void Update () {
	}

	private IEnumerator blinkRoutine() {
		while (true) {
			injectedRenderer.enabled = !injectedRenderer.enabled;
			yield return new WaitForSeconds (blinkWait);
		}
	}
}
