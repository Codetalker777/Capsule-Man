using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour {


	public float damage = 1;
	public Mario2 mario;
	// Use this for initialization
	// script used to damage the player attached to each object
	void Start () {


		mario = FindObjectOfType<Mario2>();
	}
	
	// Update is called once per frame
	void OnCollisionEnter (Collision other)
	{
		if(other.gameObject.name == "Player")
		{
			if (mario.invincible == false) {

				Debug.Log ("here");
				mario.health -= damage * Time.deltaTime;

			}
		}
	}

	void OnCollisionStay (Collision col)
	{
		if(col.gameObject.tag == "Player"){

			if (mario.invincible == false) {

				Debug.Log ("here");
				mario.health -= damage * Time.deltaTime;

			}
		}
	}
}
