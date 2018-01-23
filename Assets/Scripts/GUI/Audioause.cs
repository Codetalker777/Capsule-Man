using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audioause : MonoBehaviour {

	public int pause;
	
	// Update is called once per frame
	void Update () {

			if(Time.timeScale == 0)
			{
			GetComponent<AudioSource> ().Pause ();	
			pause = 1;
			}
		if (Time.timeScale == 1 && pause == 1) {

			GetComponent<AudioSource> ().Play ();
			pause = 0;
		}
	}
}
