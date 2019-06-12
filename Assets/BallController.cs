using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public VariableJoystick joystick;

    public float speed = 2f;
    public float verticleMove;
    public float horizontalMove;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();   
    }

    void Movement()
    {
        //Get input from joystick
        verticleMove = joystick.input.y;
        Debug.Log("Joystick" + joystick.input.y);
        horizontalMove = joystick.input.x;
    }
}
