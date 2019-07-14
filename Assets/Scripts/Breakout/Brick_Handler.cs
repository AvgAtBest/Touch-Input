using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

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
	private void Start()
	{
		ResetBricks();
	}
	private void Update()
	{
		//AssignRandomSprite();
	}
	public void ResetBricks()
	{
		foreach(GameObject brick in spawnedBricks)
		{
			Destroy(brick);
		}
		spawnedBricks.Clear();
		for (int x = 0; x < columns; x++)
		{
			for(int y = 0; y < rows; y++)
			{
				int prefabNumber = Random.Range(0, brickPrefabs.Length - 1);
				Vector2 spawnPos = (Vector2)transform.position + new Vector2(
					x * (brickPrefabs[prefabNumber].transform.localScale.x + spacing),
					-y * (brickPrefabs[prefabNumber].transform.localScale.y + spacing));
				GameObject brick = Instantiate(brickPrefabs[prefabNumber], spawnPos, Quaternion.identity);
				spawnedBricks.Add(brick);
				//for (int s = 0; s < sprites.Length; s++)
				//{
				//	int spriteNumber = Random.Range(0, sprites.Length - 1);
				//	brick.gameObject.GetComponent<SpriteRenderer>().sprite = sprites[spriteNumber];
				//}
			}
		}
	}
}
