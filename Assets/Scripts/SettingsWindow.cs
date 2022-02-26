using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering;

public class SettingsWindow : MonoBehaviour
{
    public GameObject loop, bmagent;
    public GameObject loopToggle;
    public GameObject volume;

    public AudioSource music;
    public PauseDemo pd;

    public RenderPipelineAsset[] aaLevels;

    public void SetTextureQuality(int quality)
    {
        QualitySettings.masterTextureLimit = quality;
    }

    public void SetVSync(bool isVSyncOn)
    {
        if (isVSyncOn)
        {
            QualitySettings.vSyncCount = 1;
        }
        else
        {
            QualitySettings.vSyncCount = 0;
        }
    }

    public void SetAntiAliasing(int aaLevel)
    { 
        QualitySettings.renderPipeline = aaLevels[aaLevel];
    }

    public void SetAnisotropicFiltering(int level)
    {
        QualitySettings.anisotropicFiltering = (AnisotropicFiltering)level;
    }

    public void SetPostProcessing(bool isOn)
    {
        volume.SetActive(isOn);
    }

    public void SetLoop(bool isOn)
    {
        loop.SetActive(isOn);
    }

    public void SetBenchmarkMode(bool isOn)
    {
        bmagent.SetActive(isOn);
        loopToggle.SetActive(!isOn);
    }

    public void StartDemo()
    {
        music.Play();
        pd.enabled = true;
        Cursor.visible = false;
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
