using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col; // adds a color picker to the inspector

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // spriteRenderer.color = Color.red;
        // PickARandomColor();
        // spriteRenderer.color = col;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Keyboard.current.anyKey.wasPressedThisFrame)
        {
           //PickARandomColor();
        }
        */

        //get the mouse position
        //is it over the sprite?
        //Y: use the color variable
        //N: set the color to white

        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        if (spriteRenderer.bounds.Contains(mousePos) == true)
        {
            spriteRenderer.color = col;
        }
        else
        {
            spriteRenderer.color = Color.white;
        }
    }

    void PickARandomColor()
    {
        spriteRenderer.color = Random.ColorHSV();
    }
}
