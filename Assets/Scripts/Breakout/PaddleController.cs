using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
	public VariableJoystick joystick;

	public float speed = 1f;
	public Vector2 horizontalMove;
	public Rigidbody2D rigid;
	// Start is called before the first frame update
	void Start()
	{
		//joystick = GetComponent<VariableJoystick>();
		rigid = this.GetComponent<Rigidbody2D>();
		rigid.isKinematic = false;
		rigid.constraints = RigidbodyConstraints2D.FreezeRotation | RigidbodyConstraints2D.FreezePositionY;
	}
	private void Update()
	{
		
		horizontalMove = JoyStickInput();

		//horizontalMove = KeyboardInput();
		//rigid.AddForce(horizontalMove, ForceMode2D.Impulse);
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
	//Vector2 KeyboardInput()
	//{
	//	float inputH = Input.GetAxisRaw("Horizontal");

	//	Vector2 newPos = Vector2.zero;
	//	newPos.x = inputH * speed;

	//	return newPos;
	//}

}
