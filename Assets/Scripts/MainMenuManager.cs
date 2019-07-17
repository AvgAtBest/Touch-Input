using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{

	public void GameLoad()
	{
		//Load the game scene
		SceneManager.LoadScene(1);
	}
}
