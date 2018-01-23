using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invisible : MonoBehaviour {

	public Mario2 mario;
	MeshRenderer color;
	// Use this for initialization
	void Start () {
		color = GetComponent<MeshRenderer> ();
		mario = FindObjectOfType<Mario2>();
	}
	
	// Update is called once per frame
	void Update () {

		// becomes more transparent
		if (Mathf.Abs (mario.transform.position.x - transform.position.x) <= 5 && Mathf.Abs (mario.transform.position.x - transform.position.x) > 2.0f) {

			color.enabled = true;
			color.material.color = new Color (0.9f, 0.1f, 0.8f, 1.0f * (Mathf.Abs (mario.transform.position.x - transform.position.x)/12.0f));

		} else if (Mathf.Abs (mario.transform.position.x - transform.position.x) <= 2.0f) {
			// invisibile
			color.enabled = false;
		}
			 
		else {
			// visibile
			color.enabled = true;
			color.material.color = new Color (0.9f, 0.1f, 0.8f, 1.0f);
		}

	}
}
