using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Pause : MonoBehaviour {

	public Button yourButton;
	public GameObject screen;

	void Start()
	{
		yourButton = GetComponent<Button>();
		yourButton.onClick.AddListener(TaskOnClick);
	}
		
	void TaskOnClick()
	{
		if (Time.timeScale == 1.0f) {
			screen.SetActive (true);
			Time.timeScale = 0.0f;
		} else {
			screen.SetActive (false);
			Time.timeScale = 1.0f;
		}
	}
}
