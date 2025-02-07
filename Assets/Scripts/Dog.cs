using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : CharacterController
{
    // Start is called before the first frame update
    public override void MakeNoise()
    {
        Debug.Log("Bark Bark Woof Woof");
    }

}
