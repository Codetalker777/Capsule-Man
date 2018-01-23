using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportpwup : MonoBehaviour {

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
			player.teleportpower = 5;
			player.teleport = true;
			player.longjump = false;
			player.moneyp = false;
			player.hulkmode = false;
			player.sniper = false;
			player.telecharges.SetActive (true);

		}
		Destroy (gameObject);

	}
}