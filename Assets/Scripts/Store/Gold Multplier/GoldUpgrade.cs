using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldUpgrade : MonoBehaviour {

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
		if (PlayerPrefs.GetInt ("CoinBoost") == 2 && PlayerPrefs.GetInt ("Gold") >= 100) {

			PlayerPrefs.SetInt ("CoinBoost", 3);
			gold = PlayerPrefs.GetInt ("Gold");
			gold = gold - 100;
			PlayerPrefs.SetInt ("Gold", gold);
		} else if (PlayerPrefs.GetInt ("CoinBoost") == 3 && PlayerPrefs.GetInt ("Gold") >= 200) {

			PlayerPrefs.SetInt ("CoinBoost", 4);
			gold = PlayerPrefs.GetInt ("Gold");
			gold = gold - 200;
			PlayerPrefs.SetInt ("Gold", gold);

		} else if (PlayerPrefs.GetInt ("CoinBoost") == 4 && PlayerPrefs.GetInt ("Gold") >= 500) {

			PlayerPrefs.SetInt ("CoinBoost", 5);
			gold = PlayerPrefs.GetInt ("Gold");
			gold = gold - 500;
			PlayerPrefs.SetInt ("Gold", gold);

		} else if (PlayerPrefs.GetInt ("CoinBoost") == 5 && PlayerPrefs.GetInt ("Gold") >= 1000) {

			PlayerPrefs.SetInt ("CoinBoost", 6);
			gold = PlayerPrefs.GetInt ("Gold");
			gold = gold - 1000;
			PlayerPrefs.SetInt ("Gold", gold);

		} else if (PlayerPrefs.GetInt ("CoinBoost") == 6 && PlayerPrefs.GetInt ("Gold") >= 2000) {

			PlayerPrefs.SetInt ("CoinBoost", 10);
			gold = PlayerPrefs.GetInt ("Gold");
			gold = gold - 2000;
			PlayerPrefs.SetInt ("Gold", gold);

		}
	}
}
