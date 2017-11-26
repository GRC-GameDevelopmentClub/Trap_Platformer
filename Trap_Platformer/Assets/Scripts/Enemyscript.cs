using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyscript : MonoBehaviour {
	public float speed;
	public int health;
	private Rigidbody2D rb;
	int direction = 1;
	private bool faceRight = true;
	// Use this for initialization
	void Start () {
		rb = GetComponent <Rigidbody2D> ();
	}
	float timer;
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		rb.velocity = new Vector2 (speed * direction,rb.velocity.y);
			if (timer > 2f){
				direction *= -1;
				timer = 0;
			}
		if (direction > 0 && !faceRight) {
			flip ();
		} 
		else if (direction < 0 && faceRight) {
			flip ();
		}
	}
	void flip () {
		faceRight = !faceRight;
		transform.localScale = new Vector3 (transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
	}
}


