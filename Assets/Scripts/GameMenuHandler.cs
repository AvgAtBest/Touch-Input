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
		//unfreezes game time
		Time.timeScale = 1f;
	}
	public void ToggleMenu()
	{
		
		paused = TogglePause();
	}
	public bool TogglePause()
	{
		//time is frozen
		if(Time.timeScale == 0f)
		{
			//unfreeze game time
			Time.timeScale = 1f;
			//turn off the pause menu ui
			panel.SetActive(false);
			return (false);
		}
		else
		{
			//freeze game time
			Time.timeScale = 0f;
			//turn on the pause menu ui
			panel.SetActive(true);
			return (true);
		}
	}
	public void BackToMenu()
	{
		//goes back to the main menu
		SceneManager.LoadScene(0);
	}
}
