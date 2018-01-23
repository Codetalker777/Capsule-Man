using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PriceGold : MonoBehaviour {

	public Text s;
	// Use this for initialization
	void Start () {

		s= GetComponent<UnityEngine.UI.Text>();
	}

	// Update is called once per frame
	void Update () {

		if (PlayerPrefs.GetInt ("CoinBoost") == 2) {

			s.text = "100 Gold";
		} else if (PlayerPrefs.GetInt ("CoinBoost") == 3) {

			s.text = "200 Gold";
		} else if (PlayerPrefs.GetInt ("CoinBoost") == 4) {

			s.text = "500 Gold";
		} else if (PlayerPrefs.GetInt ("CoinBoost") == 5) {

			s.text = "1000 Gold";
		} else if (PlayerPrefs.GetInt ("CoinBoost") == 6) {

			s.text = "2000 Gold";
		} else {

			s.text = "10x Boost Reached";
		}

	}
}
