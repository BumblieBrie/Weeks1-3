using UnityEngine;
using UnityEngine.InputSystem;

public class FlyMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get the mouse position to go from screen coordinates to world coordinates
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //Move the fly with the position of the mouse
        transform.position = mousePos;
    }
}
