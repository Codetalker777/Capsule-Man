using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Followplayer : MonoBehaviour {

	public Mario2 player;
	public Vector3 offset;
	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position - new Vector3(0,-5,0);
	}

	// Update is called once per frame
	void LateUpdate () {
		if (player.transform.position.x >= transform.position.x) {

			transform.position = player.transform.position + offset;

		} else if (player.transform.position.x < transform.position.x) {

			transform.position = new Vector3 (transform.position.x,player.transform.position.y,0) + offset;

		} 
	}
}
