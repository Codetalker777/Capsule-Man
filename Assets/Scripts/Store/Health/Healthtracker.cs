using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthtracker : MonoBehaviour {

	public Text s;
	// Use this for initialization
	void Start () {

		s= GetComponent<UnityEngine.UI.Text>();
	}

	// Update is called once per frame
	void Update () {

		if (PlayerPrefs.GetFloat ("Health") != 150) {

			s.text = "Health: " + PlayerPrefs.GetFloat ("Health").ToString ();
		} else {

			s.text = "";
		}

	}
}
