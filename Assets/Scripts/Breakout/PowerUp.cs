using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : OnTriggerEvent2D
{
  public float speed = 5f;

  public BallController ball;
  public PaddleController paddle;

  void Start()
  {
		//finds the ball controller in the scene
    ball = FindObjectOfType<BallController>();
		//finds the paddle controller in the scene
		paddle = FindObjectOfType<PaddleController>();
		//grabs its own rigidbody
    GetComponent<Rigidbody2D>().velocity = Vector2.down * speed;
  }

  public void RandomPowerUp()
  {
		//creates a random number
    System.Random rnd = new System.Random();
		//sets the effect to be the next value in the list
    int effect = rnd.Next(4);
		//chooses one of the effects below
    switch (effect)
    {
      case 0://speeds up the ball
        print("Ball speed increased");
				//increases the speed of the ball via its ChangeSpeed function
        ball.ChangeSpeed(1.1f);
        break;
      case 1://increases paddle size
        print("Paddle size increased");
				//increases the size of the paddle via its ChangeSizeFunction
        paddle.ChangeSize(1.1f);
        break;
      case 2://slows down the ball
        print("Ball speed decreased");
				//decreases the speed of the ball via its ChangeSpeed function
				ball.ChangeSpeed(.9f);
        break;
      case 3://decreases paddle size
				print("Paddle size decreased");
				//decreases the size of the paddle via its ChangeSizeFunction
				paddle.ChangeSize(.9f);
        break;
      default:
        break;
    }
  }
}
