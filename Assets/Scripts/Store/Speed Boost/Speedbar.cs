using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Speedbar : MonoBehaviour {

	public Button yourButton;
	public float value = 0.11f;


	// Use this for initialization
	void Start () {

		yourButton = GetComponent<Button>();

	}

	// Update is called once per frame
	void Update () {

		if (PlayerPrefs.GetFloat ("Speed") >= value) {

			GetComponent<Image> ().color = Color.black;
		} else {

			GetComponent<Image> ().color = Color.white;
		}

	}
}
