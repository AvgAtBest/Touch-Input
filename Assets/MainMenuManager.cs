using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}
	public void GameLoad()
	{
		SceneManager.LoadScene(1);
	}
	public void QuitApp()
	{
		Application.Quit();
	}
	public void OnApplicationPause(bool pause)
	{
		pause = true;
	}
}
