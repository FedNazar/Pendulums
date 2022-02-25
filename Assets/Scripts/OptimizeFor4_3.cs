using UnityEngine;

public class OptimizeFor4_3 : MonoBehaviour
{
    public float fov;
    Camera cam;

    void Awake()
    {
        if (GameObject.FindGameObjectWithTag("4_3Optimizer") != null)
        {
            cam = gameObject.GetComponent<Camera>();
            cam.fieldOfView = fov;
        }
    }
}
