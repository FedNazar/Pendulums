using UnityEngine;
using UnityEngine.SceneManagement;

public class Sequence8 : MonoBehaviour
{
    float timeValue = 0f;
    public float speed = 2f;
    public GameObject particle1, particle2;
    public GameObject wave1, wave2, wave3;
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
        if (timeValue >= 3.2f && !a[1])
        {
            a[1] = true;
            particle1.SetActive(false);
        }
        if (timeValue >= 7 && !a[2])
        {
            a[2] = true;
            waveExt1.enabled = false;
            wave2.SetActive(true);
        }
        if (timeValue >= 10 && !a[3])
        {
            a[3] = true;
            waveExt2.enabled = false;
            wave3.SetActive(true);
        }
        if (timeValue >= 14 && !a[4])
        {
            a[4] = true;
            particle2.SetActive(true);
        }
        if (timeValue >= 14.2f && !a[5])
        {
            a[5] = true;
            particle2.SetActive(false);
        }
        if (timeValue >= 17 && !a[6])
        {
            a[6] = true;
            bm = GameObject.FindGameObjectWithTag("BMAgent");
            if (bm != null)
            {
                bmagent = bm.GetComponent<BenchmarkAgent>();
                bmagent.CalculateAverageFPS();
            }
            SceneManager.LoadScene(9);
        }
    }
}
