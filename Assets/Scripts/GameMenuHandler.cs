using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameMenuHandler : MonoBehaviour
{
	bool paused;
	public GameObject panel;

	public void Start()
	{
		Time.timeScale = 1f;
	}
	public void ToggleMenu()
	{
		paused = TogglePause();
	}
	public bool TogglePause()
	{
		if(Time.timeScale == 0f)
		{
			Time.timeScale = 1f;
			panel.SetActive(false);
			return (false);
		}
		else
		{
			Time.timeScale = 0f;
			panel.SetActive(true);
			return (true);
		}
	}
	public void BackToMenu()
	{
		SceneManager.LoadScene(0);
	}
}
