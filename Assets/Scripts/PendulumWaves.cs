using UnityEngine;

public class PendulumWaves : MonoBehaviour
{
    public float angle = 0f;
    public float aSpeed = 20f, pSpeed = 2f;

    void Update()
    {
        angle += aSpeed * Time.deltaTime;
        transform.Translate(transform.forward * pSpeed * Mathf.Sin(angle) * Time.deltaTime);
    }
}
