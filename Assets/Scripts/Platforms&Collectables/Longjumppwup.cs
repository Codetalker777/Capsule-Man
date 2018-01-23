using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Longjumppwup : MonoBehaviour {

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
			player.longjump = true;
			player.moneyp = false;
			player.hulkmode = false;
			player.sniper = false;
			player.telecharges.SetActive (false);

		}
		Destroy (gameObject);

	}
}
