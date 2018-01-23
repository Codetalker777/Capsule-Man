using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRight : MonoBehaviour {


	public float speed = 1.0f;
	public float min;
	public float max;

	public float length;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if (transform.position.x < min) {

			speed = 1.0f;

		} else if (transform.position.x > max) {

			speed = -1.0f;
		}

		transform.Translate (Vector3.right * Time.deltaTime * speed);

	}
}