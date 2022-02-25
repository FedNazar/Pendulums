using UnityEngine;
using UnityEngine.SceneManagement;

public class Sequence11 : MonoBehaviour
{
    float timeValue = 0f;
    public float speed = 2f;
    AudioSource music;
    bool a1 = false;

    void Update()
    {
        timeValue += speed * Time.deltaTime;
        if (timeValue >= 17f && !a1)
        {
            a1 = true;
            if (GameObject.FindGameObjectWithTag("Looper") != null)
            {
                music = GameObject.FindGameObjectWithTag("Music").GetComponent<AudioSource>();
                music.Stop();
                music.Play();
                SceneManager.LoadScene(1);
            }
        }
    }
}