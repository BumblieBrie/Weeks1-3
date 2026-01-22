using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class Controls : MonoBehaviour
{
    public bool leftMouseIsPressed = false;
    public bool rightMouseIsPressed = false;
    public bool anyKeyIsPressed = false;

    public float speed = 3f;
    public float rotationSpeed = 100f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());


        //isPressed is true all the time the button is pressed i.e holding down the mouse button will keep it true
        leftMouseIsPressed = Mouse.current.leftButton.isPressed;
        rightMouseIsPressed = Mouse.current.rightButton.isPressed;

        // wasPressedThisFrame is true only the first frame the button is pressed
        // wasReleasedThisFrame is true only the first frame the button is pressed
        if (Mouse.current.leftButton.wasPressedThisFrame == true)
        {
            Debug.Log("Left Button Was Pressed");
        }
        if (Mouse.current.rightButton.wasPressedThisFrame == true)
        {
            Debug.Log("Right Button Was Pressed");
        }

        anyKeyIsPressed = Keyboard.current.anyKey.isPressed;

        //test for specific movement from the arrow keys

        if (Keyboard.current.leftArrowKey.isPressed == true)
        {
            Vector3 newRotation = transform.eulerAngles;
            newRotation.z += rotationSpeed * Time.deltaTime;
            transform.eulerAngles = newRotation;
        }
        if (Keyboard.current.rightArrowKey.isPressed == true)
        {
            Vector3 newRotation = transform.eulerAngles;
            newRotation.z -= rotationSpeed * Time.deltaTime;
            transform.eulerAngles = newRotation;
        }
        if (Keyboard.current.upArrowKey.isPressed == true)
        {
            // HAVE TO CHANGE THESE TO USING DIRECTIONAL MOVEMENT SO THE CAR FOLLOWS ITS ROTATION
            /*Vector2 newPosition = transform.position;
            newPosition.y += speed * Time.deltaTime;
            transform.position = newPosition;
            */
            transform.position += transform.up * speed * Time.deltaTime;
        }
        if (Keyboard.current.downArrowKey.isPressed == true)
        {
            /*
            Vector2 newPosition = transform.position;
            newPosition.y -= speed * Time.deltaTime;
            transform.position = newPosition;
            */
            transform.position -= transform.up * speed * Time.deltaTime;
        }
    }
}
