using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Controller
{
    public KeyCode moveForward;
    public KeyCode moveBackward;
    public KeyCode moveLeft;
    public KeyCode rotateClockwise;
    public KeyCode rotateCounterclockwise;

    // Start is called before the first frame update
    public override void Start()
    {
        
    }

    // Update is called once per frame
    public override void Update()
    {
        if (Input.GetKey(moveForward))
        {
            // Move it forward
            pawn.MoveForward();
        }

        if (Input.GetKey(moveBackward))
        {
            // Move it backward
            pawn.MoveBackward();   
        }

        if (Input.GetKey(rotateClockwise))
        {
            // Clockwise it
            pawn.RotateClockwise();
        }

        if (Input.GetKey(rotateCounterclockwise))
        {
            //CounterClockwise it
            pawn.RotateCounterclockwise();
        }
    }
}
