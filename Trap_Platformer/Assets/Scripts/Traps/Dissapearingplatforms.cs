using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissapearingplatforms : MonoBehaviour {
	public float fallingspeed;
	float time;
	private bool IsTrapground;
	private Vector2 originalPos;
	public GameObject PlayerObject;
	private PlayerCollision PlayerScript;

	void Start (){
		originalPos = this.transform.position;
	}
	// Update is called once per frame
	void Update () {
		PlayerScript = PlayerObject.GetComponent<PlayerCollision> ();
		Debug.Log (originalPos);
		Debug.Log (PlayerScript.isDead());
		Debug.Log ("currnt pos" + this.transform.position);
		if (PlayerScript.isDead()) {
			Debug.Log ("MOVE BITCH");
			this.transform.position = originalPos;
		}

		if (IsTrapground) {
			time += Time.deltaTime;
		}

		if (IsTrapground == true && time > fallingspeed) {
			this.transform.position = new Vector2 (10, 10);
			time = 0f;
			IsTrapground = false;
		}
	}
	private void OnCollisionStay2D (Collision2D collision) {

		Debug.Log ("collision");

		if (collision.gameObject.CompareTag ("Player")) {
			IsTrapground = true;

		}
	}
}
