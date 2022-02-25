using UnityEngine;

public class CameraRotator : MonoBehaviour
{
    public Transform platrormAxis;
    public float speed = 5;

    void Update()
    {
        gameObject.transform.RotateAround(platrormAxis.position, Vector3.up, 20 * speed * Time.deltaTime);
    }
}
