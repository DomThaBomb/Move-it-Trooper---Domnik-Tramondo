using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : CharacterController
{
    public override void MakeNoise()
    {
        Debug.Log("Meow Meow Hiss Hiss");
    }
}
