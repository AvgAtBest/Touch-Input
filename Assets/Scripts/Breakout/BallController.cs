using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{


	public float speed = 5f;
	public float verticleMove;
	public float horizontalMove;

	// Start is called before the first frame update
	void Start()
	{
		Respawn_Ball_Default();
	}

	// Update is called once per frame
	public void Respawn_Ball_Default()
	{
		transform.position = Vector3.zero;
		GetComponent<Rigidbody2D>().velocity = Random.insideUnitCircle.normalized * speed;
	}

}
