using UnityEngine;
using UnityEngine.InputSystem;

public class Rollover : MonoBehaviour
{
    public bool mouseIsOverMe = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //get the mouse position (in pixels) and convert it to world space in metres
        //get the distance between the transform position and the mouse position
        //if that distance is less than 1 metre, set mouseIsOverMe to true, otherwise set it to false

        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        float distance = Vector2.Distance(transform.position, mousePos);
        if (distance < 1f)
        {
            mouseIsOverMe = true;
        }
        else
        {
            mouseIsOverMe = false;
        }
    }
}