using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	private Rigidbody2D rb;
	public float speed;
	private bool isOnGround;
	public float jumpforce;
	private float moveX;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.UpArrow) && isOnGround) { //Player jumps
			Jump ();
		}
		}
	private void OnCollisionEnter2D (Collision2D collision){ 
		if (collision.gameObject.CompareTag ("Ground")) {
			isOnGround = true;
		}
		}
	private void FixedUpdate(){
		moveX = Input.GetAxis ("Horizontal");
		rb.velocity = new Vector2 (moveX * speed, rb.velocity.y); // Move
		}

	private void Jump(){
		rb.velocity = new Vector2 (rb.velocity.x, jumpforce); //Jump
		isOnGround = false;
	}
	 }
