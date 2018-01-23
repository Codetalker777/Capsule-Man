using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroylevel2 : MonoBehaviour {

	public Generatelv2 script;
	public GameObject cam;

	public GameObject[] platforms;
	public float count = 1;
	public string x;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		// it deletes all of the objects associated with the tag 1-10 depending on the count
		if (cam.transform.position.x - 10 >= script.total && count < script.id_num-1) {

			x = count.ToString();
			platforms = GameObject.FindGameObjectsWithTag (x);

			foreach (GameObject platform in platforms) {

				Debug.Log (platform.name + " " + platform.tag);
				Destroy (platform);
			}
			count = count + 1;
		}
	}

}
