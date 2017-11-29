using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blades : MonoBehaviour {
	private SpriteRenderer sprite;
	public Transform player;
	public float actDistance;
	private float timer;
	private float direction;
	public float speed;
	Vector2 originalPos;
	public float size;
	// Use this for initialization
	void Start () {
		sprite = GetComponent <SpriteRenderer> ();
		sprite.enabled = false;
		originalPos = this.transform.position;
		direction = 1;
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate (0, direction * speed, 0);
		if (Distance (this.transform.position, player.position) < actDistance ) {
			sprite.enabled = true;
		}
		if (Mathf.Abs(this.transform.position.y) > Mathf.Abs(originalPos.y + size)) {
			direction *= -1;
		}
	}
	private float Distance (Vector2 pos1, Vector2 pos2){
		float equation = Mathf.Sqrt(Mathf.Pow(pos2.x - pos1.x, 2)+Mathf.Pow(pos2.y - pos1.y, 2));
		return equation;
	}
	private void OnTriggerEnter2D (Collider2D coll){
		GameObject player;
		if (coll.CompareTag ("Player")){
			player = coll.gameObject;
			player.GetComponent<PlayerCollision> ().Death = true;
		}
	}
}
