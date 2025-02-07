using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipInput : MonoBehaviour
{

    public KeyCode keypress;

    public float xMin;
    public float xMax;
    public float yMin;
    public float yMax;
    private Transform transform;

    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        // Move up every frame draw by adding 1 to the y of our position
        transform.position = transform.position + (Vector3.up * 0.01f); // Vector3.up is a preset Vector of (0,1,0) 
        // There is also a Vector3.right (1,0,0) and Vector3.forward (0,0,1)

        if (Input.GetKeyDown(keypress))
        {
            // Change the position to some random x and y location
            Vector3 position = new Vector3(Random.Range(xMin, xMax), Random.Range(yMin, yMax), 0);
            transform.SetPositionAndRotation(position, Quaternion.identity);

            Vector3 myVector = new Vector3(2, 4, 12);
            myVector = myVector.normalized; // You could also call the function myVector.Normalize();
            transform.position = transform.position + (myVector * speed * Time.deltaTime);
        }
    }
}

