using UnityEngine;
using UnityEngine.SceneManagement;

public class Sequence3 : MonoBehaviour
{
    float timeValue = 0f;
    public float speed = 2f;
    public float decrSpeed = 5f;
    public PendulumMotion pm;
    bool a = false;

    GameObject bm;
    BenchmarkAgent bmagent;

    void Update()
    {
        timeValue += speed * Time.deltaTime;
        pm.pSpeed -= decrSpeed * Time.deltaTime;
        if (timeValue >= 8.5f && !a)
        {
            a = true;
            bm = GameObject.FindGameObjectWithTag("BMAgent");
            if (bm != null)
            {
                bmagent = bm.GetComponent<BenchmarkAgent>();
                bmagent.CalculateAverageFPS();
            }
            SceneManager.LoadScene(4);
        }
    }
}
