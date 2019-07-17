using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
	public VariableJoystick joystick;

	public float speed = 1f;
	public float keyboardSpeed = 4f;
	public Vector2 horizontalMove;
	public Rigidbody2D rigid;
	public Vector2 startPos;

	// Start is called before the first frame update
	void Start()
	{
		//sets the start position of the paddle
		startPos = gameObject.transform.position;
		//gets the rigidbody
		rigid = this.GetComponent<Rigidbody2D>();
		//the rigidbody isnt kinematic
		rigid.isKinematic = false;
		//freezes the rotation and y position of the rigidbody
		rigid.constraints = RigidbodyConstraints2D.FreezeRotation | RigidbodyConstraints2D.FreezePositionY;
	}

	private void Update()
	{
		//if there is input to the joystick (horizontal only)
    if (JoyStickInput().x != 0)
    {
			//then paddle movement is handled via joystick input
      horizontalMove = JoyStickInput();
    }
		//otherwise if there is currently keyboard input being detected
    else if (Input.GetAxis("Horizontal") != 0)
    {
			//paddle movement is being handled by getaxis times the speed
      horizontalMove = new Vector2(Input.GetAxis("Horizontal"), 0) * keyboardSpeed;
    }
    else
    {
			//its vector in the world is zero
      horizontalMove = Vector2.zero;
    }
		//apply velocity to the rigidbody via the input timed by speed
    rigid.velocity = Vector2.right * horizontalMove * speed;
	}

	Vector2 JoyStickInput()
	{
		//gets the axis of the joystick
		Vector2 inputDirection = joystick.GetAxis();
		Vector2 newPos = Vector2.zero;
		//the new position to move the paddle to is equal to the input on the x axis timed by speed
		newPos.x = inputDirection.x * speed;
		newPos.y = inputDirection.y;
		Debug.Log("Joystick" + joystick.input.x);
		//returns the new position
		return newPos;
	}

	public void ResetPaddle()
	{
		//simply resets the input and its rigidbody to zero
		horizontalMove = Vector2.zero;
		rigid.velocity = Vector2.zero;
		//returns it to the starting position
		gameObject.transform.position = startPos;
	}
	//changes the size of the paddle timed by the multiplier via powerup
	public void ChangeSize(float multiplier)
  {

		//changes the local scale of the paddle
    transform.localScale = new Vector2(transform.localScale.x * multiplier, transform.localScale.y);
  }
}
