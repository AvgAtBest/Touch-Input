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
    ball = FindObjectOfType<BallController>();
    paddle = FindObjectOfType<PaddleController>();

    GetComponent<Rigidbody2D>().velocity = Vector2.down * speed;
  }

  public void RandomPowerUp()
  {
    System.Random rnd = new System.Random();
    int effect = rnd.Next(4);

    switch (effect)
    {
      case 0:
        print("Ball speed increased");
        ball.ChangeSpeed(1.1f);
        break;
      case 1:
        print("Paddle size increased");
        paddle.ChangeSize(1.1f);
        break;
      case 2:
        print("Ball speed decreased");
        ball.ChangeSpeed(.9f);
        break;
      case 3:
        print("Paddle size decreased");
        paddle.ChangeSize(.9f);
        break;
      default:
        break;
    }
  }
}
