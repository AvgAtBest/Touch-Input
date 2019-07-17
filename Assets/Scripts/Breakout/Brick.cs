using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
	public Sprite[] sprites;

	public int health = 2;
	public int curHealth;

  SpriteRenderer thisBrick;
	ScoreManager score;

  public GameObject powerup;
  // Start is called before the first frame update
	public void Start()
	{
		//gets the score manager
		score = GameObject.Find("Game").GetComponent<ScoreManager>();
		//set the current health to maxhealth
		curHealth = health;
		//grabs the sprite renderer component
		thisBrick = GetComponent<SpriteRenderer>();
	}
	private void Update()
	{
		//if the current health exceeds the maximum health
		if (curHealth > health)
		{
			//set it back to maxhealth, preventing overflow
			curHealth = health;
			//sets the sprite to be the default unbroken sprite
			thisBrick.sprite = sprites[0];
		}
		//if the current health is less than maxhealth and its not death
		if (curHealth < health && curHealth > 0)
		{
			//change the sprite to be a broken brick
			thisBrick.sprite = sprites[1];
		}
	}
	private void OnCollisionEnter2D(Collision2D collision)
	{
		//take one health away from the brick
		curHealth -= 1;
		//adds 50 to the players score for hitting it
		score.AddScore(50);
		//if the current health is less than 1
		if (curHealth < 1)
		{
			//get the brick handler component in the scene
			Brick_Handler bh = FindObjectOfType<Brick_Handler>().GetComponent<Brick_Handler>();
			//adds 100 to the players score for destroying it
			score.AddScore(100);
			//remove  the brick from the list
			bh.spawnedBricks.Remove(gameObject);
			//if there isnt a powerup
      if (powerup)
      {
				//randomly generate a effect
        System.Random rnd = new System.Random();
        int effect = rnd.Next(2);
				//creates a powerup
        switch (effect)
        {
          case 0:
            print("Powerup spawned");
            Instantiate(powerup, transform.position, transform.rotation);
            break;
          default:
            break;
        }
      }
			//destroy the brick
      Destroy(gameObject);
		}
	}
}
