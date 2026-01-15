using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Vector2 beginPos;
    public Vector2 endPos;
    public float t = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        beginPos = transform.position;
        endPos = new Vector2(8f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        transform.position = Vector2.Lerp(beginPos, endPos, t);
        Vector2 screenPos = Camera.main.ScreenToWorldPoint(endPos);

        if (transform.position == (Vector3)endPos)
        {
            beginPos = endPos;
            endPos = new Vector2(Random.Range(0, Screen.width), Random.Range(0, Screen.height));
            t = 0f;
        }
    }
}
