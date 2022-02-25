using UnityEngine;
using UnityEngine.SceneManagement;

public class Sequence7 : MonoBehaviour
{
    float timeValue = 0f;
    public float speed = 2f;
    public GameObject particle1, particle2;
    public GameObject wave1, wave2;
    public WaveExtender waveExt1;
    public Transform sCamPos, sCamAxis;
    public CameraRotator cr;
    public MeshRenderer vBox;
    public Material vBoxMaterial;

    bool[] a = { false, false, false, false, false, false, false };

    GameObject bm;
    BenchmarkAgent bmagent;

    void Update()
    {
        timeValue += speed * Time.deltaTime;
        if (timeValue >= 7 && !a[0])
        {
            a[0] = true;
            transform.position = sCamPos.position;
            transform.rotation = sCamPos.rotation;
            cr.platrormAxis = sCamAxis;
            cr.speed = -0.3f;
            vBox.material = vBoxMaterial;
        }
        if (timeValue >= 9 && !a[1])
        {
            a[1] = true;
            particle1.SetActive(true);
            wave1.SetActive(true);
        }
        if (timeValue >= 9.2f && !a[2])
        {
            a[2] = true;
            particle1.SetActive(false);
        }
        if (timeValue >= 15 && !a[3])
        {
            a[3] = true;
            waveExt1.enabled = false;
            wave2.SetActive(true);
        }
        if (timeValue >= 23 && !a[4])
        {
            a[4] = true;
            particle2.SetActive(true);
        }
        if (timeValue >= 23.2f && !a[5])
        {
            a[5] = true;
            particle2.SetActive(false);
        }
        if (timeValue >= 29 && !a[6])
        {
            a[6] = true;
            bm = GameObject.FindGameObjectWithTag("BMAgent");
            if (bm != null)
            {
                bmagent = bm.GetComponent<BenchmarkAgent>();
                bmagent.CalculateAverageFPS();
            }
            SceneManager.LoadScene(8);
        }
    }
}

