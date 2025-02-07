using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    // Declare all of our variables after the curly bracket ({)

    public SpriteRenderer theRenderer; // variable for "The Renderer"
    public Color spriteColor; // Variable for "Sprite Color"

    // Start is called before the first frame update
    void Start()
    {
        // Load the SpriteRenderer component from the same object that the component is on 
        theRenderer = gameObject.GetComponent<SpriteRenderer>();

        // Change the "color" from our color picker so that the alpha is 1
        spriteColor.a = 1.0f;

        // As long as theRenderer has been set
        if (theRenderer != null)
        {
            // Change the "color" value of the SpriteRenderer component to our new color
            theRenderer.color = spriteColor;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
