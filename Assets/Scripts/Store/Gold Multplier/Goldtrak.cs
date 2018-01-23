using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goldtrak : MonoBehaviour {

	public Text s;
	// Use this for initialization
	void Start () {

		s= GetComponent<UnityEngine.UI.Text>();
	}

	// Update is called once per frame
	void Update () {

		if (PlayerPrefs.GetInt ("CoinBoost") != 10) {

			s.text = "Boost: " + PlayerPrefs.GetInt ("CoinBoost").ToString () + "x";
		} else {

			s.text = "";
		}

	}
}
