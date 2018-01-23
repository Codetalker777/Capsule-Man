using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zerogravityupgrade : MonoBehaviour {

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
		if (PlayerPrefs.GetInt ("Zerogravity") == 0 && PlayerPrefs.GetInt ("Gold") >= 2000) {

			PlayerPrefs.SetInt ("Zerogravity", 1);
			gold = PlayerPrefs.GetInt ("Gold");
			gold = gold - 2000;
			PlayerPrefs.SetInt ("Gold", gold);
		} 
	}
}
