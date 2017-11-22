using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

    public Transform target;
    public float speed;
    public float zoom;
    public Vector2 offSet;

    private Vector3 camPosition;

	// Use this for initialization
	void Start () {
        camPosition = new Vector2(target.position.x, target.position.y);

        this.transform.position = camPosition;
	}
	
	// Update is called once per frame
	void Update () {

        camPosition = this.transform.position;
        camPosition.x += (target.position.x - this.transform.position.x) * speed;
        camPosition.y += (target.position.y - this.transform.position.y) * speed;

        this.transform.position = new Vector3(camPosition.x + offSet.x, camPosition.y + offSet.y, zoom);
	}
}
