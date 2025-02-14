using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteRotation : MonoBehaviour
{
    private Transform move; // Create a variable for our transform component
    public float turnSpeed; // Create a variable for the degrees we rotate in one frame draw
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Transform tf = GetComponent<Transform>();
        tf.position = tf.position + (GetComponent<Transform>().TransformDirection(new Vector3(1, 1, 0)) * turnSpeed);

        tf.Rotate(0, turnSpeed, 0); // Rotate "turnSpeed" degrees on the Y axis

        Transform transform = GetComponent<Transform>();
        tf.Translate(Vector3.up, Space.World); // Relative movement up (in world space)
        tf.Translate(Vector3.up, Space.Self); // Relative movement up (in local space)
    }
}
