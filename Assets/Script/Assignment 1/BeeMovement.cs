using UnityEngine;

public class BeeMovement : MonoBehaviour
{
    public Transform startPos;
    public Transform endPos;
    public AnimationCurve curve;

    public float t;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move the bee along a lerp function
        //add an animation curve so that the bee looks like it's flying around more naturally
        //originally wanted the bee to fly around more but realized its LINEAR interpolation so it can only go straight
        //or at least that's what it seems like
        //want the bee to bounce back and forth between the two points
        //make the end position the new start position and the start position the new end position
        //originally tried to do this with a boolean, but realized it was easier to just adjust the if statements
        if (t < 1)
        {
            t += 0.5f * Time.deltaTime;
            transform.position = Vector2.Lerp(startPos.position, endPos.position, curve.Evaluate(t));
        }
        else if(1 < t && t < 2) //check if t has reached 1 which means its at the end position
            //let t keep counting up to 2 so we can use the same variable to switch the direction of the lerp
        {
            t += 0.5f * Time.deltaTime;
            transform.position = Vector2.Lerp(endPos.position, startPos.position, curve.Evaluate(t - 1));
        }
        else if (t >= 2)
        {
            t = 0;
        }
    }
}
