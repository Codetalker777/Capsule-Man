using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PriceHealth : MonoBehaviour {

	public Text s;
	// Use this for initialization
	void Start () {

		s= GetComponent<UnityEngine.UI.Text>();
	}

	// Update is called once per frame
	void Update () {

		if (PlayerPrefs.GetFloat ("Health") == 100) {

			s.text = "100 Gold";
		} else if (PlayerPrefs.GetFloat ("Health") == 110) {

			s.text = "200 Gold";
		} else if (PlayerPrefs.GetFloat ("Health") == 120) {

			s.text = "500 Gold";
		} else if (PlayerPrefs.GetFloat ("Health") == 130) {

			s.text = "1000 Gold";
		} else if (PlayerPrefs.GetFloat ("Health") == 140) {

			s.text = "2000 Gold";
		} else {

			s.text = "Max Level 150 Reached";
		}

	}
}
