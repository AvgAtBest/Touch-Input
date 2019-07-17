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
		startPos = gameObject.transform.position;
		//joystick = GetComponent<VariableJoystick>();
		rigid = this.GetComponent<Rigidbody2D>();
		rigid.isKinematic = false;
		rigid.constraints = RigidbodyConstraints2D.FreezeRotation | RigidbodyConstraints2D.FreezePositionY;
	}

	private void Update()
	{
    if (JoyStickInput().x != 0)
    {
      horizontalMove = JoyStickInput();
    }
    else if (Input.GetAxis("Horizontal") != 0)
    {
      horizontalMove = new Vector2(Input.GetAxis("Horizontal"), 0) * keyboardSpeed;
    }
    else
    {
      horizontalMove = Vector2.zero;
    }

    rigid.velocity = Vector2.right * horizontalMove * speed;
	}

	Vector2 JoyStickInput()
	{
		Vector2 inputDirection = joystick.GetAxis();
		Vector2 newPos = Vector2.zero;
		newPos.x = inputDirection.x * speed;
		newPos.y = inputDirection.y;
		Debug.Log("Joystick" + joystick.input.x);

		return newPos;
	}

	public void ResetPaddle()
	{
		horizontalMove = Vector2.zero;
		rigid.velocity = Vector2.zero;
		gameObject.transform.position = startPos;
	}

  public void ChangeSize(float multiplier)
  {
    transform.localScale = new Vector2(transform.localScale.x * multiplier, transform.localScale.y);
  }
}
