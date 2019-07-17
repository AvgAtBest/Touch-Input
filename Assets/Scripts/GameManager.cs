using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public bool gameover;
	public GameObject gameoverPanel, winUiPanel, pauseUIPanel;
	// Start is called before the first frame update
	void Start()
	{
		gameover = false;
		Time.timeScale = 1f;
	}

	// Update is called once per frame
	public void GameOver()
	{
		//gameover, enabled gameover panel
		gameover = true;
		gameoverPanel.SetActive(true);
		Time.timeScale = 0f;
	}
	public void ResetGame()
	{
		//reloads the scene and unfreezes time
		Time.timeScale = 1f;

    SceneManager.LoadScene(1);
  }
  public void BackToMenu()
	{
		//back to the main menu
		SceneManager.LoadScene(0);
	}
}
