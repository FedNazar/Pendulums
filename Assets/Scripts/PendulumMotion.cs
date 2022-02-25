using UnityEngine;

public class PendulumMotion : MonoBehaviour
{
    float angle = 0f;
    public float aSpeed = 20f, pSpeed = 2f;

    void Update()
    {
        angle += aSpeed * Time.deltaTime;
        transform.Rotate(transform.forward * pSpeed * Mathf.Sin(angle) * Time.deltaTime);
    }
}
