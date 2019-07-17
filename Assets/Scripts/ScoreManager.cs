using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{
	public int startScore = 0;
	public int currentScore;
	public TextMeshProUGUI text;
	public void Start()
	{
		//current score is 0 at the start
		currentScore = startScore;
	}
	private void Update()
	{
		//update the score text
		text.text = currentScore.ToString();
	}
	public void AddScore(int score)
	{
		//adds the score to the current score
		currentScore += score;

	}
	public void ResetScore()
	{
		//resets it
		currentScore = startScore;
	}
}
