using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blades : MonoBehaviour {
	private SpriteRenderer sprite;
	public Transform player;


	// Use this for initialization
	void Start () {
		sprite = GetComponent <SpriteRenderer> ();
		sprite.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private float Distance (Vector2 pos1, Vector2 pos2){
	
	}
}
