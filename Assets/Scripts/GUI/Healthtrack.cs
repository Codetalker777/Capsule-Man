using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Healthtrack : MonoBehaviour {

	public Text s;
	public Mario2 mario;
	// Use this for initialization
	void Start () {

		s= GetComponent<UnityEngine.UI.Text>();
	}

	// Update is called once per frame
	void Update () {

		s.text = mario.health.ToString ();

	}
}
