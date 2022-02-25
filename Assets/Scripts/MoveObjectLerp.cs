using UnityEngine;

public class MoveObjectLerp : MonoBehaviour
{
    public Transform destPoint;
    public float lerpRatio = 5f;

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, destPoint.position, lerpRatio * Time.deltaTime);
    }
}
