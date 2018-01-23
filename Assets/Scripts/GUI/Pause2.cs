using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause2 : MonoBehaviour {


	public void Checkpause () {

		Debug.Log ("work");
		if (Time.timeScale == 0.0f) {

			Time.timeScale = 1;
			Debug.Log ("unpause pressed");

		} else if (Time.timeScale == 1.0f) {

			Time.timeScale = 0;
			Debug.Log ("pause pressed");

		}
	}
}
