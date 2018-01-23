using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoad : MonoBehaviour
{
	public string x;

	public void NextScene()
	{
		SceneManager.LoadScene(x);
		Debug.Log ("worked");
	}
}
