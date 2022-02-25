using UnityEngine;

public class BlinkingLamp : MonoBehaviour
{
    float timeValue = 0f;
    public float speed = 2f;

    public Light lampLight;
    public Material lampOn, lampOff;
    public MeshRenderer lamp;

    public bool isOn = false;
    public float interval = 3f;

    void Update()
    {
        timeValue += speed * Time.deltaTime;

        if (timeValue >= interval)
        {
            timeValue = 0f;
            if (!isOn)
            {
                lamp.material = lampOn;
                lampLight.enabled = true;
            }
            else
            {
                lamp.material = lampOff;
                lampLight.enabled = false;
            }
            isOn = !isOn;
        }
    }
}
