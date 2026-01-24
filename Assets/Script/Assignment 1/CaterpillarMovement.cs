using UnityEngine;
using UnityEngine.UIElements;

public class CaterpillarMovement : MonoBehaviour
{
    public Transform startPos;
    public Transform endPos;

    public float t = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //have the caterpillar move from start to end positions using Lerp
        //once it reaches the end position, have it return to the start position and repeat

        if (t < 1)
        {
            t += 0.1f * Time.deltaTime;
            transform.position = Vector2.Lerp(startPos.position, endPos.position, t);
        }
        else if (t >= 1)
        {
            t = 0;
        }
    }
}
