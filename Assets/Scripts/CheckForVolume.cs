using UnityEngine;
using UnityEngine.Rendering.Universal;

public class CheckForVolume : MonoBehaviour
{
    UniversalAdditionalCameraData cam;

    void Awake()
    {
        cam = gameObject.GetComponent<UniversalAdditionalCameraData>();
        if (GameObject.FindGameObjectWithTag("Volume") != null)
        {
            cam.renderPostProcessing = true;
        }
    }
}
