using UnityEngine;

public class PauseDemo : MonoBehaviour
{
    AudioSource music;
    public bool paused = false;

    void Start()
    {
        music = gameObject.GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !paused)
        {
            paused = true;
            Time.timeScale = 0;
            music.Pause();
        }
        else if (Input.GetMouseButtonDown(0) && paused)
        {
            paused = false;
            Time.timeScale = 1;
            music.UnPause();
        }
    }
}
