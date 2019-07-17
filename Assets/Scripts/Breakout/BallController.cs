using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
  public float speed = 15f;
  public float verticleMove;
  public float horizontalMove;
  public bool ballHitBounds;

  // Start is called before the first frame update
  void Start()
  {
    ballHitBounds = false;
    Respawn_Ball_Default();
  }

  // Update is called once per frame
  public void Respawn_Ball_Default()
  {
    //reset the hitbounds bool to false
    ballHitBounds = false;
    //reset the ball back to the start
    transform.position = Vector3.zero;
    GetComponent<Rigidbody2D>().velocity = Random.insideUnitCircle.normalized * speed;
  }
  public void BallHasHitBounds()
  {
    //ball has hit the bounds
    ballHitBounds = true;
    //call game over function
    FindObjectOfType<GameManager>().GameOver();
  }
	//changes the speed of the balls rigidbody velocity timed by the multiplier via powerup
  public void ChangeSpeed(float multiplier)
  {
    GetComponent<Rigidbody2D>().velocity *= multiplier;
  }
}
