using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Speedtracker : MonoBehaviour {

	// Use this for initialization
	public Text s;
	public float divider = 0.1f;
	public float store;
	// Use this for initialization
	void Start () {

		s= GetComponent<UnityEngine.UI.Text>();
	}

	// Update is called once per frame
	void Update () {

		if (PlayerPrefs.GetFloat ("Speed") != 0.15f) {

			store = (PlayerPrefs.GetFloat ("Speed")) / divider;
			store = store * 100;

			s.text = "Boost: " + store.ToString() + "%";
		} else {

			s.text = "";
		}

	}
}
