using UnityEngine;
using UnityEngine.InputSystem;

public class VibrateMouseOver : MonoBehaviour
{
    public bool timerIsRunning = false;
    public float timer = 0f;
    public AnimationCurve vibrateCurve;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        float distance = Vector2.Distance(mousePos, transform.position);

        Vector2 newPosition = transform.position;

        if (distance < 1f)
        {
            timerIsRunning = true;
        }
        else
        {
            timerIsRunning = false;
        }

        if (timerIsRunning == true)
        {
            timer += Time.deltaTime;

            newPosition += (Vector2)(vibrateCurve.Evaluate(timer * 5f) * 0.1f * Random.insideUnitSphere);
        }
        else
        {
            timer = 0f;
            newPosition.x = 0f;
            newPosition.y = 0f;
        }
        transform.position = newPosition;
    }
}
