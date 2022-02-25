using UnityEngine;
using UnityEngine.SceneManagement;

public class BenchmarkAgent : MonoBehaviour
{
    public float[] fpsValues = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float frameCount;

    public void CalculateAverageFPS()
    {
        fpsValues[SceneManager.GetActiveScene().buildIndex - 1] =
            (Time.frameCount - frameCount) / Time.timeSinceLevelLoad;
        frameCount = Time.frameCount;
    }
}
