using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Enemydestroyed1 : MonoBehaviour {

	public Text s;
	public Mario2 mario;
	// Use this for initialization
	void Start () {

		s= GetComponent<UnityEngine.UI.Text>();
	}

	// Update is called once per frame
	void Update () {

		s.text = mario.enemieskilled.ToString();

	}
}
