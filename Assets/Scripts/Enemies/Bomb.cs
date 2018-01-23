using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour {

	public float time = 5.0f;
	public float speed = 1.0f;

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	// bomb of bomber
	void Update () {

		time -= Time.deltaTime;


		transform.Translate (Vector3.down * Time.deltaTime * speed);

		if (time <= 0) {

			GetComponent<MeshRenderer> ().enabled = false;
			GetComponent<SphereCollider> ().enabled = false;

			transform.position = transform.parent.position;
			time = 5.0f;

		}
		if (time > 0) {

			GetComponent<MeshRenderer> ().enabled = true;
			GetComponent<SphereCollider> ().enabled = true;

		}

	}
}
