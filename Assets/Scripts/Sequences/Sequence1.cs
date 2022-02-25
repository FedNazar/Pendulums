using UnityEngine;
using UnityEngine.SceneManagement;

public class Sequence1 : MonoBehaviour
{
    float timeValue = 0f;
    public float speed = 2f;
    public Light l1, l2, l3, l4, l5, l6;
    public MoveObject moveObj;
    public CameraRotator camR;
    bool[] a = {false, false, false, false, false};

    GameObject bm;
    BenchmarkAgent bmagent;

    void Start()
    {
        bm = GameObject.FindGameObjectWithTag("BMAgent");
        if (bm != null)
        {
            bmagent = bm.GetComponent<BenchmarkAgent>();
            bmagent.frameCount = Time.frameCount;
        }
    }

    void Update()
    {
        timeValue += speed * Time.deltaTime;
        if (timeValue >= 2f && !a[0])
        {
            a[0] = true;
            l1.enabled = true;
        }
        if (timeValue >= 4.5f && !a[1])
        {
            a[1] = true;
            l2.enabled = true;
        }
        if (timeValue >= 10 && !a[2])
        {
            a[2] = true;
            l1.enabled = false;
            l3.enabled = true;
            l4.enabled = true;
        }
        if (timeValue >= 12.5f && !a[3])
        {
            a[3] = true;
            camR.enabled = true;
            moveObj.enabled = false;
            l5.enabled = true;
            l6.enabled = true;
            l2.enabled = false;
        }
        if (timeValue >= 22f && !a[4])
        {
            a[4] = true;
            if (bmagent != null)
            {
                bmagent.CalculateAverageFPS();
            }
            SceneManager.LoadScene(2);
        }
    }
}
