using UnityEngine;

public class Ticking : MonoBehaviour
{
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed = 0f;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.eulerAngles -= new Vector3(0, 0, speed);
     
    }
}
