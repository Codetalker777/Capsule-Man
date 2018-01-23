using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AddGold : MonoBehaviour {

	public Button yourButton;
	public int gold = 5000;

	void Start()
	{
		yourButton = GetComponent<Button>();
		yourButton.onClick.AddListener(TaskOnClick);
	}

	// resets the date when button clicked
	void TaskOnClick()
	{
		gold += PlayerPrefs.GetInt ("Gold");
		PlayerPrefs.SetInt ("Gold", gold);
		gold = 5000;
	}
}
