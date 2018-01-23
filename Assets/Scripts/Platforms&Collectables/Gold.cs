using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : MonoBehaviour {

	public int value;
	public GameObject x;
	public AudioSource cash;

	void Start () {

		x = GameObject.FindGameObjectWithTag ("Cash");
		cash = x.GetComponent<AudioSource> ();

	}

	void OnTriggerEnter (Collider other) {

		if (other.gameObject.tag == "Player") {

			value = PlayerPrefs.GetInt ("Gold");
			if (other.GetComponent<Mario2> ().moneyp == true) {

				if (PlayerPrefs.HasKey("CoinBoost") == true) {

					//adds bonus based on coinboost
					value = value + PlayerPrefs.GetInt ("CoinBoost");
					PlayerPrefs.SetInt ("Gold", value);
					cash.Play ();
					Destroy (gameObject);

				} else {

					value = value + 2;
					PlayerPrefs.SetInt ("CoinBoost", 2);
					PlayerPrefs.SetInt ("Gold", value);
					cash.Play ();
					Destroy (gameObject);


				}

			} else {

				value = value + 1;
				PlayerPrefs.SetInt ("Gold", value);
				cash.Play ();
				Destroy (gameObject);

			}
		}

	}
}
