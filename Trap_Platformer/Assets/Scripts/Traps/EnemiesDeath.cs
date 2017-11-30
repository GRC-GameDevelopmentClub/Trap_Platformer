using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesDeath : MonoBehaviour {
	public int health;
	private bool death;
	public float bounceForce;
	GameObject player;
	private int originalhealth;


	// Use this for initialization
	void Start () {
		originalhealth = health;
	}
	
	// Update is called once per frame
	void Update () {
		if (health <= 0) {
			death = true;
		}
		if (death) {
			Destroy (this.gameObject);
		}
		if (player.GetComponent <PlayerCollision> ().Death) {
			health = originalhealth;
		}
	}

	private void OnTriggerEnter2D (Collider2D collider){
		if (collider.CompareTag("Player") ){
			health -= 1;
			player = collider.gameObject;
			player.GetComponent<PlayerMovement> ().GetRigidbody2D ()
				.AddForce (new Vector2 (0, bounceForce));
		}
	}
}
