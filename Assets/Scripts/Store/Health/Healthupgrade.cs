using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Healthupgrade : MonoBehaviour {

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
		if (PlayerPrefs.GetFloat ("Health") == 100 && PlayerPrefs.GetInt ("Gold") >= 100) {

			PlayerPrefs.SetFloat ("Health", 110);
			gold = PlayerPrefs.GetInt ("Gold");
			gold = gold - 100;
			PlayerPrefs.SetInt ("Gold", gold);
		} else if (PlayerPrefs.GetFloat ("Health") == 110 && PlayerPrefs.GetInt ("Gold") >= 200) {

			PlayerPrefs.SetFloat ("Health", 120);
			gold = PlayerPrefs.GetInt ("Gold");
			gold = gold - 200;
			PlayerPrefs.SetInt ("Gold", gold);

		} else if (PlayerPrefs.GetFloat ("Health") == 120 && PlayerPrefs.GetInt ("Gold") >= 500) {

			PlayerPrefs.SetFloat ("Health", 130);
			gold = PlayerPrefs.GetInt ("Gold");
			gold = gold - 500;
			PlayerPrefs.SetInt ("Gold", gold);

		} else if (PlayerPrefs.GetFloat ("Health") == 130 && PlayerPrefs.GetInt ("Gold") >= 1000) {

			PlayerPrefs.SetFloat ("Health", 140);
			gold = PlayerPrefs.GetInt ("Gold");
			gold = gold - 1000;
			PlayerPrefs.SetInt ("Gold", gold);

		} else if (PlayerPrefs.GetFloat ("Health") == 140 && PlayerPrefs.GetInt ("Gold") >= 2000) {

			PlayerPrefs.SetFloat ("Health", 150);
			gold = PlayerPrefs.GetInt ("Gold");
			gold = gold - 2000;
			PlayerPrefs.SetInt ("Gold", gold);

		}
	}
}
