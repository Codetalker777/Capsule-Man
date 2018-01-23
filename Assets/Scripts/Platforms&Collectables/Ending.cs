using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending : MonoBehaviour {

	public Mario2 mario;

	void Start() {

		mario = FindObjectOfType<Mario2> ();
	}
		

	void Update() {


		if (Mathf.Abs (mario.transform.position.x - transform.position.x) <= 5) {

			mario.Finish.SetActive (true);
			Time.timeScale = 0;
		}

	}
}
