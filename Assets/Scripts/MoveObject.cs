using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float speed = 5f;
    // Directions
    public bool forward = false, up = false, right = false;

    void Update()
    {
        if (forward)
        {
            transform.Translate(transform.forward * speed * Time.deltaTime);
        }
        if (up)
        {
            transform.Translate(transform.up * speed * Time.deltaTime);
        }
        if (right)
        {
            transform.Translate(transform.right * speed * Time.deltaTime);
        }
    }
}
