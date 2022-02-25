using UnityEngine;
using UnityEngine.SceneManagement;

public class Sequence6 : MonoBehaviour
{
    float timeValue = 0f;
    public float speed = 2f;
    public MoveObject moveObj;
    public CameraRotator camR;
    public Transform sCamPos, tCamPos;
    public GameObject formula, building1, building2, building3, building4, building5;
    public GameObject mainFormula;
    bool[] a = { false, false, false, false, false, false, false, false };

    GameObject bm;
    BenchmarkAgent bmagent;

    void Update()
    {
        timeValue += speed * Time.deltaTime;
        if (timeValue >= 10 && !a[0])
        {
            a[0] = true;
            camR.enabled = false;
            moveObj.enabled = true;
            transform.position = sCamPos.position;
            transform.rotation = sCamPos.rotation;
        }
        if (timeValue >= 17 && !a[1])
        {
            a[1] = true;
            moveObj.speed = 0.2f;
            moveObj.right = false;
            moveObj.up = true;
            mainFormula.SetActive(false);
            transform.position = tCamPos.position;
            transform.rotation = tCamPos.rotation;
        }
        if (timeValue >= 20 && !a[2])
        {
            a[2] = true;
            formula.SetActive(true);
            building1.SetActive(true);
            building2.SetActive(true);
        }
        if (timeValue >= 21 && !a[3])
        {
            a[3] = true;
            building3.SetActive(true);
            building4.SetActive(true);
        }
        if (timeValue >= 22 && !a[4])
        {
            a[4] = true;
            building5.SetActive(true);
        }
        if (timeValue >= 23 && !a[5])
        {
            a[5] = true;
            formula.SetActive(false);
        }
        if (timeValue >= 23.5f && !a[6])
        {
            a[6] = true;
            formula.SetActive(true);
        }
        if (timeValue >= 27.5f && !a[7])
        {
            a[7] = true;
            bm = GameObject.FindGameObjectWithTag("BMAgent");
            if (bm != null)
            {
                bmagent = bm.GetComponent<BenchmarkAgent>();
                bmagent.CalculateAverageFPS();
            }
            SceneManager.LoadScene(7);
        }
    }
}

