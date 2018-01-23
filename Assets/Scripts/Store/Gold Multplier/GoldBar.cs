using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldBar : MonoBehaviour {

	public Button yourButton;
	public int multiplier = 3;


	// Use this for initialization
	void Start () {

		yourButton = GetComponent<Button>();

	}

	// Update is called once per frame
	void Update () {

		if (PlayerPrefs.GetInt ("CoinBoost") >= multiplier) {

			GetComponent<Image> ().color = Color.black;
		} else {

			GetComponent<Image> ().color = Color.white;
		}

	}
}
