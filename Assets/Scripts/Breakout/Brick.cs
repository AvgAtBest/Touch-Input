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
		score = GameObject.Find("Game").GetComponent<ScoreManager>();
		curHealth = health;
		thisBrick = GetComponent<SpriteRenderer>();
	}
	private void Update()
	{
		if (curHealth > health)
		{
			curHealth = health;
			thisBrick.sprite = sprites[0];
		}
		if (curHealth < health && curHealth > 0)
		{
			thisBrick.sprite = sprites[1];
		}
	}
	private void OnCollisionEnter2D(Collision2D collision)
	{
		curHealth -= 1;
		score.AddScore(50);
		if (curHealth < 1)
		{
			Brick_Handler th = FindObjectOfType<Brick_Handler>().GetComponent<Brick_Handler>();
			score.AddScore(100);
			th.spawnedBricks.Remove(gameObject);

      if (powerup)
      {
        System.Random rnd = new System.Random();
        int effect = rnd.Next(2);

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

      Destroy(gameObject);
		}
	}
}
