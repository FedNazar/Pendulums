using UnityEngine;
using UnityEngine.UI;

public class BenchmarkStats : MonoBehaviour
{
    public Text[] labels;
    BenchmarkAgent bmagent;
    double averageFPS = 0f, averageSceneFPS;

    void Start()
    {
        bmagent = GameObject.FindGameObjectWithTag("BMAgent").GetComponent<BenchmarkAgent>();
        for (int i = 0; i < 10; i++)
        {
            averageSceneFPS = Mathf.Round(bmagent.fpsValues[i] * 100) * 0.01;
            labels[i + 1].text += averageSceneFPS;
            averageFPS += averageSceneFPS;
        }
        labels[0].text += averageFPS / 10;
    }
    
}
