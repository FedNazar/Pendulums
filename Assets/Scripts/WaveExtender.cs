using UnityEngine;

public class WaveExtender : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        transform.localScale = new Vector3
            (transform.localScale.x, transform.localScale.y,
            transform.localScale.z + speed * Time.deltaTime);
    }
}
