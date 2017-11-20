using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	private Rigidbody2D rb;
	public float speed;
	float moveX;
	float moveY;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();

		
	}
	
	// Update is called once per frame
	void Update () {
		moveX = Input.GetAxis ("Horizontal");
		moveY = Input.GetAxis ("Vertical");
		rb.velocity = new Vector2(moveX * speed,moveY * speed);

	}
}
