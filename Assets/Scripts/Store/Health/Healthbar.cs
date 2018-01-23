using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour {

	public Button yourButton;
	public float value = 110.0f;


	// Use this for initialization
	void Start () {

		yourButton = GetComponent<Button>();

	}
	
	// Update is called once per frame
	void Update () {

		if (PlayerPrefs.GetFloat ("Health") >= value) {

			GetComponent<Image> ().color = Color.black;
		} else {

			GetComponent<Image> ().color = Color.white;
		}

	}
}
