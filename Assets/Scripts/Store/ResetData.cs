using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ResetData : MonoBehaviour {

	public Button yourButton;

	void Start()
	{
		yourButton = GetComponent<Button>();
		yourButton.onClick.AddListener(TaskOnClick);
	}

	// resets the date when button clicked
	void TaskOnClick()
	{
		PlayerPrefs.SetInt ("Gold", 0);
		PlayerPrefs.SetFloat ("Health", 100.0f);
		PlayerPrefs.SetFloat ("Speed", 0.1f);
		PlayerPrefs.SetInt ("CoinBoost", 2);
		PlayerPrefs.SetInt ("Zerogravity", 0);
		PlayerPrefs.SetInt ("OnOffZero", 0);

	}
}
