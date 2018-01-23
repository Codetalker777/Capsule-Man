using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PriceSpeed : MonoBehaviour {

	public Text s;
	// Use this for initialization
	void Start () {

		s= GetComponent<UnityEngine.UI.Text>();
	}

	// Update is called once per frame
	void Update () {

		if (PlayerPrefs.GetFloat ("Speed") == 0.1f) {

			s.text = "100 Gold";
		} else if (PlayerPrefs.GetFloat ("Speed") == 0.11f) {

			s.text = "200 Gold";
		} else if (PlayerPrefs.GetFloat ("Speed") == 0.12f) {

			s.text = "500 Gold";
		} else if (PlayerPrefs.GetFloat ("Speed") == 0.13f) {

			s.text = "1000 Gold";
		} else if (PlayerPrefs.GetFloat ("Speed") == 0.14f) {

			s.text = "2000 Gold";
		} else {

			s.text = "Max Speed boost 150%";
		}

	}
}
