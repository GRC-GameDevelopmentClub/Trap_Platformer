using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	private bool Death;
	public GameObject respawn;

	private void OnCollisionEnter2D (Collision2D collision){
		if (collision.gameObject.CompareTag ("Enemy")) {
			Death = true;
			}
		}
	void Update () {
		if (Death == true) {
			gameObject.transform.position = respawn.transform.position;
			Death = false;
		}
	}
}

