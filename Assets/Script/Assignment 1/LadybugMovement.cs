using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.InputSystem;

public class LadybugMovement : MonoBehaviour
{
    public bool mouseIsOverMe = false;

    public AnimationCurve vibrate;
    public float t;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //check if the mouse is over the ladybug

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

        // set it up so the animation curve controls the position when the mouse is over the ladybug

        //fix it so that the ladybug doesn't teleport to 0,0 when the mouse is over it
        //fix it so the ladybug doesn't run away when the mouse is over it

        if (mouseIsOverMe == true)
        {
            t += Time.deltaTime * 2f;

            if (t > 1)
            {
                t = 0;
            }
          
            Vector2 newPosition = transform.position;
            newPosition.x = 6.22f + vibrate.Evaluate(t);
            newPosition.y = 0.99f + vibrate.Evaluate(t);
            transform.position = newPosition;
        }
    }
}
