using UnityEngine;

public class Floating : MonoBehaviour
{
    public float speed = 0;
    public AnimationCurve curve;
    //public float movement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPosition = transform.position;
        transform.position = new Vector2(newPosition.x, newPosition.y);
        transform.position = newPosition;

        speed += Time.deltaTime;
        if (speed >= 1){
            
            speed = 0;
            newPosition.y = newPosition.y += curve.Evaluate(speed) * -1;
            transform.position = newPosition;

        }
        if(speed < 1)
        {
            newPosition.y = newPosition.y += curve.Evaluate(speed);
            transform.position = newPosition;
        }
    }
}
