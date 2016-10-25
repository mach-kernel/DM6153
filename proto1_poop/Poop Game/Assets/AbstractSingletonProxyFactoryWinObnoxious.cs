using UnityEngine;
using System.Collections;
// not actually abstract or a proxy or a singleton or a factory BUT CERTAINLY OBNOXIOUS
public class AbstractSingletonProxyFactoryWinObnoxious : MonoBehaviour {
	void OnTriggerEnter2D(Collider2D other) {
		if (other.name.Contains ("Character")) {
			Application.LoadLevel ("MainScene");
		}
	}
}
