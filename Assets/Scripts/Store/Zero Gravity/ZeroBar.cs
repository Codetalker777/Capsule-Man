using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZeroBar : MonoBehaviour {

	public Button yourButton;
	public int value = 1;


	// Use this for initialization
	void Start () {

		yourButton = GetComponent<Button>();

	}

	// Update is called once per frame
	void Update () {

		if (PlayerPrefs.GetInt ("Zerogravity") == 1) {

			GetComponent<Image> ().color = Color.black;
		} else {

			GetComponent<Image> ().color = Color.white;
		}

	}
}
