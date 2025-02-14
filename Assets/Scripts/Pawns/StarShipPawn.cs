using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarShipPawn : Pawn
{
    public override void MoveBackward()
    {
        Debug.Log("Move Backward");
    }

    public override void MoveForward()
    {
        Debug.Log("Move Forward");
    }

    public override void RotateClockwise()
    {
        Debug.Log("Rotate Clockwise");
    }

    public override void RotateCounterclockwise()
    {
        Debug.Log("Rotate Counter clockwise");
    }

    // Start is called before the first frame update
    public override void Start()
    {
        
    }

    // Update is called once per frame
    public override void Update()
    {
        
    }

}
