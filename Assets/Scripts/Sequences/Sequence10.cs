using UnityEngine;
using UnityEngine.SceneManagement;

public class Sequence10 : MonoBehaviour
{
    float timeValue = 0f;
    public float speed = 2f;
    bool a = false;

    GameObject bm;
    BenchmarkAgent bmagent;

    void Update()
    {
        timeValue += speed * Time.deltaTime;
        if (timeValue >= 20.5f && !a)
        {
            a = true;
            bm = GameObject.FindGameObjectWithTag("BMAgent");
            if (bm != null)
            {
                bmagent = bm.GetComponent<BenchmarkAgent>();
                bmagent.CalculateAverageFPS();
                SceneManager.LoadScene(13);
            }
            else
            {
                SceneManager.LoadScene(11);
            }
        }
    }
}