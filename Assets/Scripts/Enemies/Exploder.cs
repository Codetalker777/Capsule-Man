using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exploder : MonoBehaviour {

	public Mario2 mario;
	float timer = 5.0f;
	public BoxCollider x;
	public ParticleSystem explode;
	public Rigidbody test;
	public float distance;
	public MeshRenderer color;
	private IEnumerator Coroutine;

	public GameObject find;
	public AudioSource explodenoise;

	// Use this for initialization
	void Start () {

		find = GameObject.FindGameObjectWithTag ("Explode");
		explodenoise = find.GetComponent<AudioSource> ();
		mario = FindObjectOfType<Mario2> ();
		x = GetComponent<BoxCollider> ();
		explode = GetComponent<ParticleSystem> ();
		test = GetComponent<Rigidbody> ();
		color = GetComponent<MeshRenderer> ();

	}
	
	// Update is called once per frame
	void Update () {

		timer -= Time.deltaTime;

		// every 5 seconds it moves to player location
		if (timer <= 0) {

			transform.position = mario.transform.position;
			//explode.Play();
			x.enabled = false;
			color.material.color = new Color (0.823f, 0.7058f, 0.55f, 0.0f);
			StartCoroutine(StopExplode(2)); 
			Invoke ("Explosion", 1.0f);
			//accounting for explosion time
			timer = 6;

		}

	}

	void Explosion() {

		explode.Play ();
		explodenoise.Play ();
		//test.AddExplosionForce(1.0f, transform.position, 3.0f, 0.0f);

		Collider[] hitColliders = Physics.OverlapSphere(transform.position, 3.0f);

		int i = 0;
		while (i < hitColliders.Length)
		{
			if (hitColliders [i].gameObject.tag == "Player") {

				if (hitColliders [i].GetComponent<Mario2> ().invincible == false) {

					distance = Vector3.Distance (hitColliders [i].transform.position, transform.position);
					Mathf.Abs (distance);
					//damage
					hitColliders [i].GetComponent<Mario2> ().health -= ((3.0f - distance) / 3.0f) * 10;
					//force
					hitColliders[i].GetComponent<Rigidbody>().AddExplosionForce(1.0f, transform.position, 3.0f, 0.0f);

				}
			}
			i++;
		}
		color.material.color = new Color (0.823f, 0.7058f, 0.55f, 1.0f);
		x.enabled = true;

	}

	IEnumerator StopExplode(int howangry) {

		yield return new WaitForSeconds(howangry);
		explode.Stop ();
	}
}
