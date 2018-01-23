using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDown : MonoBehaviour {


	public float speed = 1.0f;

	public float length;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (transform.position.y < 0) {

			speed = 1.0f;

		} else if (transform.position.y > 4) {
			
			speed = -1.0f;
		}

		transform.Translate (Vector3.up * Time.deltaTime * speed);

	}
}
