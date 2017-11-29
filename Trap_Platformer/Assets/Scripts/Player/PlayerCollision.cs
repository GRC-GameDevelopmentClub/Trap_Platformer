using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {
	public bool Death;
	public GameObject respawn;
	private float timer;


	private void OnCollisionEnter2D (Collision2D collision){
		if (collision.gameObject.CompareTag ("Enemy")) {
			Death = true;
			}
		}
	void Update () {
		Debug.Log ("collision death"+ Death);
		if (Death == true) {
			gameObject.transform.position = respawn.transform.position;
			timer += Time.deltaTime;
		}
		if (timer > 0.1f) {
			Death = false;
			timer = 0;
		}
	}

	public bool isDead(){
		return Death;
	}
}

