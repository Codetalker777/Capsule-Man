using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedUpgrade : MonoBehaviour {

	public Button yourButton;

	public int gold;

	void Start()
	{
		yourButton = GetComponent<Button>();
		yourButton.onClick.AddListener(TaskOnClick);
	}

	// resets the date when button clicked
	void TaskOnClick()
	{
		if (PlayerPrefs.GetFloat ("Speed") == 0.1f && PlayerPrefs.GetInt ("Gold") >= 100) {

			PlayerPrefs.SetFloat ("Speed", 0.11f);
			gold = PlayerPrefs.GetInt ("Gold");
			gold = gold - 100;
			PlayerPrefs.SetInt ("Gold", gold);
		} else if (PlayerPrefs.GetFloat ("Speed") == 0.11f && PlayerPrefs.GetInt ("Gold") >= 200) {

			PlayerPrefs.SetFloat ("Speed", 0.12f);
			gold = PlayerPrefs.GetInt ("Gold");
			gold = gold - 200;
			PlayerPrefs.SetInt ("Gold", gold);

		} else if (PlayerPrefs.GetFloat ("Speed") == 0.12f && PlayerPrefs.GetInt ("Gold") >= 500) {

			PlayerPrefs.SetFloat ("Speed", 0.13f);
			gold = PlayerPrefs.GetInt ("Gold");
			gold = gold - 500;
			PlayerPrefs.SetInt ("Gold", gold);

		} else if (PlayerPrefs.GetFloat ("Speed") == 0.13f && PlayerPrefs.GetInt ("Gold") >= 1000) {

			PlayerPrefs.SetFloat ("Speed", 0.14f);
			gold = PlayerPrefs.GetInt ("Gold");
			gold = gold - 1000;
			PlayerPrefs.SetInt ("Gold", gold);

		} else if (PlayerPrefs.GetFloat ("Speed") == 0.14f && PlayerPrefs.GetInt ("Gold") >= 2000) {

			PlayerPrefs.SetFloat ("Speed", 0.15f);
			gold = PlayerPrefs.GetInt ("Gold");
			gold = gold - 2000;
			PlayerPrefs.SetInt ("Gold", gold);

		}
	}
}
