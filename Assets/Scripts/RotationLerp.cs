using UnityEngine;

public class RotationLerp : MonoBehaviour
{
    public Transform destRotation;
    public float lerpRatio = 5f;

    void Update()
    { 
        transform.rotation = Quaternion.Lerp(transform.rotation, destRotation.rotation, lerpRatio * Time.deltaTime);
    }
}
