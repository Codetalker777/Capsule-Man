using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hulkpwup : MonoBehaviour {

	public Mario2 player;
	public GameObject x;
	public AudioSource cash;

	// Use this for initialization
	void Start () {

		x = GameObject.FindGameObjectWithTag ("Powerup");
		cash = x.GetComponent<AudioSource> ();
		player = FindObjectOfType<Mario2> ();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter (Collider other) {

		if (other.gameObject.tag == "Player") {

			cash.Play ();
			player.teleportpower = 0;
			player.teleport = false;
			player.longjump = false;
			player.moneyp = false;
			player.hulkmode = true;
			player.sniper = false;
			player.telecharges.SetActive (false);
		}
		Destroy (gameObject);

	}
}
