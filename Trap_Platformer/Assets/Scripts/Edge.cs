using UnityEngine;

public class Edge : MonoBehaviour {

	public GameObject respawn;

	void OnTriggerEnter2D (Collider2D collider ){
		if (collider.tag == "Player") {
			collider.transform.position = respawn.transform.position;
		}
	}
}
