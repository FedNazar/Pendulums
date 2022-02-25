using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering;

public class SettingsWindow : MonoBehaviour
{
    Resolution[] resolutions;
    public Dropdown resDropdown;

    public GameObject opt43, loop, bmagent;
    public GameObject loopToggle;
    public GameObject volume;

    public Toggle fullScrToggle;

    public AudioSource music;
    public PauseDemo pd;

    public RenderPipelineAsset[] aaLevels;

    void Start()
    {
        resolutions = Screen.resolutions;
        resDropdown.ClearOptions();
        List<string> options = new List<string>();
        int curRes = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);
            if (resolutions[i].width == Screen.currentResolution.width &&
                resolutions[i].height == Screen.currentResolution.height)
            {
                curRes = i;
            }
        }

        resDropdown.AddOptions(options);
        resDropdown.value = curRes;
        resDropdown.RefreshShownValue();

        fullScrToggle.isOn = Screen.fullScreen;
    }
    
    public void SetResolution(int resolution)
    {
        Screen.SetResolution(resolutions[resolution].width, resolutions[resolution].height,
            Screen.fullScreen);
    }

    public void SetFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }

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

    public void Set43Optimization(bool isOn)
    {
        opt43.SetActive(isOn);
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
