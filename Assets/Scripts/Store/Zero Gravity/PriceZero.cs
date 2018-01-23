using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PriceZero : MonoBehaviour {

	public Text s;
	// Use this for initialization
	void Start () {

		s= GetComponent<UnityEngine.UI.Text>();
	}

	// Update is called once per frame
	void Update () {

		if (PlayerPrefs.GetInt ("Zerogravity") == 0) {

			s.text = "2000 Gold";
		} else {

			s.text = "Purchased";
		}

	}
}
