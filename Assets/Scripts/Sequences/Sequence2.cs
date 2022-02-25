using UnityEngine;
using UnityEngine.SceneManagement;

public class Sequence2 : MonoBehaviour
{
    public Camera cam;
    float timeValue = 0f;
    public float speed = 2f;
    public MoveObject moveObj;
    public CameraRotator camR;
    public Transform sCamPos;
    bool[] a = { false, false };

    GameObject bm;
    BenchmarkAgent bmagent;

    void Update()
    {
        timeValue += speed * Time.deltaTime;
        if (timeValue >= 8 && !a[0])
        {
            a[0] = true;
            camR.enabled = false;
            moveObj.enabled = true;
            transform.position = sCamPos.position;
            transform.rotation = sCamPos.rotation;
        }
        if (timeValue >= 14 && !a[1])
        {
            a[1] = true;
            bm = GameObject.FindGameObjectWithTag("BMAgent");
            if (bm != null)
            {
                bmagent = bm.GetComponent<BenchmarkAgent>();
                bmagent.CalculateAverageFPS();
            }
            SceneManager.LoadScene(3);
        }
    }
}
