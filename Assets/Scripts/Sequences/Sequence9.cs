using UnityEngine;
using UnityEngine.SceneManagement;

public class Sequence9 : MonoBehaviour
{
    float timeValue = 0f;
    public float speed = 2f;
    public GameObject wave1, wave2;
    public GameObject particle1, particle2;
    public Light particle2Light;
    public WaveExtender waveExt1, waveExt2;

    bool[] a = { false, false, false, false, false, false, false };

    GameObject bm;
    BenchmarkAgent bmagent;

    void Update()
    {
        timeValue += speed * Time.deltaTime;
        if (timeValue >= 3 && !a[0])
        {
            a[0] = true;
            particle1.SetActive(true);
            wave1.SetActive(true);
        }
        if (timeValue >= 3.2 && !a[1])
        {
            a[1] = true;
            particle1.SetActive(false);
        }
        if (timeValue >= 7 && !a[2])
        {
            a[2] = true;
            particle2.SetActive(true);
        }
        if (timeValue >= 11 && !a[3])
        {
            a[3] = true;
            waveExt1.enabled = false;
            wave2.SetActive(true);
        }
        if (timeValue >= 15 && !a[4])
        {
            a[4] = true;
            particle2Light.intensity *= 4;
            particle2Light.range *= 4;
        }
        if (timeValue >= 19 && !a[5])
        {
            a[5] = true;
            waveExt2.enabled = false;
        }
        if (timeValue >= 22 && !a[6])
        {
            a[6] = true;
            bm = GameObject.FindGameObjectWithTag("BMAgent");
            if (bm != null)
            {
                bmagent = bm.GetComponent<BenchmarkAgent>();
                bmagent.CalculateAverageFPS();
            }
            SceneManager.LoadScene(10);
        }
    }
}
