using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissapearingplatforms : MonoBehaviour {
	float time;
	private bool IsTrapground;

	// Update is called once per frame
	void Update () {

		Debug.Log (time);

		if (IsTrapground) {
			time += Time.deltaTime;
		}
		
		if (IsTrapground == true && time > 0.5f) {
			Destroy (gameObject);
			time = 0f;
		}
	}
	private void OnCollisionStay2D (Collision2D collision) {

		Debug.Log ("collision");

		if (collision.gameObject.CompareTag ("Player")) {
			IsTrapground = true;

		}
	}
}
