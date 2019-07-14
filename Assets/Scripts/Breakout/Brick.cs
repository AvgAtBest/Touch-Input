using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
	public Sprite[] sprites;
	public int health = 2;
	public int curHealth;
	SpriteRenderer thisBrick;
	// Start is called before the first frame update
	public void Start()
	{
		curHealth = health;
		 thisBrick = GetComponent<SpriteRenderer>();
	}
	private void Update()
	{
		if(curHealth > health)
		{
			curHealth = health;
			thisBrick.sprite = sprites[0];
		}
		if(curHealth < health && curHealth > 0)
		{
			thisBrick.sprite = sprites[1];
		}
	}
	private void OnCollisionEnter2D(Collision2D collision)
	{
		curHealth -= 1;
		if(curHealth < 1)
		{
			Destroy(gameObject);
		}
	}
}
