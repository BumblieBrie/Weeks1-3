using UnityEngine;
// NEED TO FINISH ADDING A TIMER

public class Timer : MonoBehaviour
{
    public float newSpotX;
    public float newSpotY;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        newSpotX = Random.Range(-10f, 10f);
        newSpotY = Random.Range(-5f, 5f);

        transform.position = (Vector2)transform.position + Random.insideUnitCircle * 2;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.x = newSpotX;
        newPosition.y = newSpotY;
        transform.position = newPosition;

       
    }
}
