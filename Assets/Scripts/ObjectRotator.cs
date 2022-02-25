using UnityEngine;

public class ObjectRotator : MonoBehaviour
{
    public float speed = 5f;
    // Axis
    public bool forward = false, up = false, right = false;

    void Update()
    {
        if (forward)
        {
            transform.Rotate(transform.forward * speed * Time.deltaTime);
        }
        if (up)
        {
            transform.Rotate(transform.up * speed * Time.deltaTime);
        }
        if (right)
        {
            transform.Rotate(transform.right * speed * Time.deltaTime);
        }
    }
}
