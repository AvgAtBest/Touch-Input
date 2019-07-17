using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class Brick_Handler : MonoBehaviour
{
	public int rows;
	public int columns;
	public float spacing;
	public GameObject brickPrefab;
	public GameObject[] brickPrefabs;
	//public List<GameObject> brickPrefabs = new List<GameObject>();
	public List<GameObject> spawnedBricks = new List<GameObject>();
	public Sprite[] sprites;
	public GameObject winUI;
	private void Start()
	{
		ResetBricks();
	}
	private void Update()
	{
		//AssignRandomSprite();
		if(spawnedBricks.Count == 0)
		{
			WinUI();
			Debug.Log("You won");
		}
	}
	public void ResetBricks()
	{
		//for each of the bricks in the list
		foreach(GameObject brick in spawnedBricks)
		{
			//Destroy the bricks
			Destroy(brick);
		}
		//clear the list
		spawnedBricks.Clear();
		//loop through columns array
		for (int x = 0; x < columns; x++)
		{
			//loop through rows arraw
			for(int y = 0; y < rows; y++)
			{
				//randomly chooses a brick prefab to spawn out of aray
				int prefabNumber = Random.Range(0, brickPrefabs.Length - 1);
				//Gets the co ordinates to spawn
				Vector2 spawnPos = (Vector2)transform.position + new Vector2(
					x * (brickPrefabs[prefabNumber].transform.localScale.x + spacing),
					-y * (brickPrefabs[prefabNumber].transform.localScale.y + spacing));
				//spawns the brick at the spawn position
				GameObject brick = Instantiate(brickPrefabs[prefabNumber], spawnPos, Quaternion.identity);
				//adds the brick to the list
				spawnedBricks.Add(brick);

			}
		}
	}
	public void WinUI()
	{
		winUI.SetActive(true);
		Time.timeScale = 0f;
	}
}
