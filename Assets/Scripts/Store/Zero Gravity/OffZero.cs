using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OffZero : MonoBehaviour {

	public Button yourButton;
	public GameObject on;

	public int gold;

	void Start()
	{
		yourButton = GetComponent<Button>();
		yourButton.onClick.AddListener(TaskOnClick);

		if (PlayerPrefs.GetInt ("OnOffZero") == 0) {

			GetComponent<Image> ().color = Color.green;
			on.GetComponent<Image> ().color = Color.red;
		}
	}

	// resets the date when button clicked
	void TaskOnClick()
	{
		if (PlayerPrefs.GetInt ("Zerogravity") == 1 && PlayerPrefs.GetInt ("OnOffZero") == 1) {

			PlayerPrefs.SetInt ("OnOffZero", 0);
			GetComponent<Image> ().color = Color.green;
			on.GetComponent<Image> ().color = Color.red;
		}
	}
}
