using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Music : MonoBehaviour {

	AudioSource x;
	int count = 0;

	void Awake ()
	{
		// leaves this object running
		GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
		if (objs.Length > 1)
			Destroy(this.gameObject);

		DontDestroyOnLoad(this.gameObject);

	}

	void Start () {

		x = GetComponent<AudioSource> ();

	}

	void Update()
	{
		//only runs in menus
		if (SceneManager.GetActiveScene ().name == "Level 1" || SceneManager.GetActiveScene ().name == "Level 2" || SceneManager.GetActiveScene ().name == "Level 3") {
			x.Pause ();
			count = 1;
		} else if (count == 1 && SceneManager.GetActiveScene ().name == "Main Menu") {

			x.Play ();
			count = 0;
		}
	}
}
