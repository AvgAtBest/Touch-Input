using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounds : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D collision)
	{
		//call the function on the ball notifying it has hit the bounds
		collision.GetComponent<BallController>().BallHasHitBounds();
		
	}
}
