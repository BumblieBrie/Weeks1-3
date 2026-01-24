using UnityEngine;

public class RaindropMovement : MonoBehaviour
{
    public float speed = 0.05f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //set it up so I can change the position of the raindrop
        //make the raindrop fall down the screen at a consistent speed

        //make the raindrop reappear at the top of the screen when it goes off the bottom
        //fix screen position to world position for the screen height
        //uhhh fix the raindrop from falling eternally
        //make it so that it appears at the top of the screen no matter what size the screen is
;

        Vector2 newPosition = transform.position;
        newPosition.y -= speed;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);

        if (screenPos.y < -Screen.height)
        {
            newPosition.y = 5f;

        }
        transform.position = newPosition;

        Debug.Log(screenPos);

    }
}
