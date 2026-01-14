using UnityEngine;
// NEED TO FINISH ADDING A TIMER

public class Timer : MonoBehaviour
{
    public float newSpotX;
    public float newSpotY;

    public float teleport = 0; 
    public float timer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        timer = Time.deltaTime;

        transform.position = (Vector2)transform.position + Random.insideUnitCircle * 2;
    }

    // Update is called once per frame
    void Update()
    {
        teleport += timer;
        if (teleport > 3)
        {
            newSpotX = Random.Range(-10f, 10f);
            newSpotY = Random.Range(-5f, 5f);

            Vector3 newPosition = transform.position;
            newPosition.x = newSpotX;
            newPosition.y = newSpotY;
            transform.position = newPosition;
            teleport = 0;
        }



    }
}
