using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deathzones : MonoBehaviour {


	public Mario2 player;
	public float rate = 1.0f;

	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.tag == "Player"){

			player = col.gameObject.GetComponent<Mario2> ();
			player.health = player.health - rate * Time.deltaTime;
		}
	}

	void OnCollisionStay (Collision col)
	{
		if(col.gameObject.tag == "Player"){

			player = col.gameObject.GetComponent<Mario2> ();
			player.health = player.health - rate * Time.deltaTime;
		}
	}


}
