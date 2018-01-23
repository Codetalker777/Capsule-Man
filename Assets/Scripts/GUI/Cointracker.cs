using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cointracker : MonoBehaviour {

	public Text s;
	// Use this for initialization
	void Start () {

		s= GetComponent<UnityEngine.UI.Text>();
	}

	// Update is called once per frame
	void Update () {

		s.text = PlayerPrefs.GetInt ("Gold").ToString ();

	}
}
