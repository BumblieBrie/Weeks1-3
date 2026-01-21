using UnityEngine;

public class RotateMe : MonoBehaviour
{
    public float speed = 100f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newRotation = transform.eulerAngles;
        newRotation.z += speed * Time.deltaTime;
        transform.eulerAngles = newRotation;

        //when using empty game objects to change the centre of rotation, change the move tool to pivot instead of centre
    }
}
