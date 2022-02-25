using UnityEngine;
using UnityEngine.SceneManagement;

public class Sequence4 : MonoBehaviour
{
    float timeValue = 0f;
    public float speed = 2f;
    public Camera cam;
    public RotationLerp rl;
    public MoveObjectLerp mol1, mol2, mol3, mol4, mol5, molg;
    public Transform p2dp, p3dp, p4dp;
    public Transform _0T, _T2, _34T14T;
    public Transform fDestPointEnd;
    public MeshRenderer cable1, cable2, capacitor1, capacitor2;
    public Material cableMat, capacitorMat;
    public Material qPlus, qMinus, qStream1, qStream2;
    public GameObject h1, h2, mgh;

    bool[] a = { false, false, false, false, false };

    int tab = 0, o = 0;
    public GameObject music;
    PauseDemo pause;
    AudioSource audioS;
    bool hda = false;

    GameObject bm;
    BenchmarkAgent bmagent;

    void Start()
    {
        music = GameObject.FindGameObjectWithTag("Music");
    }

    void Update()
    {
        timeValue += speed * Time.deltaTime;
        if (timeValue >= 8 && !a[0])
        {
            a[0] = true;
            rl.destRotation = _34T14T;
            mol1.destPoint = fDestPointEnd;
            mol2.enabled = true;
            molg.enabled = true;
            cable1.material = qStream1;
            capacitor1.material = capacitorMat;
            capacitor2.material = capacitorMat;
            h1.SetActive(false);
        }
        if (timeValue >= 16 && !a[1])
        {
            a[1] = true;
            rl.destRotation = _T2;
            mol2.destPoint = fDestPointEnd;
            mol3.enabled = true;
            molg.destPoint = p2dp;
            cable1.material = cableMat;
            capacitor1.material = qMinus;
            capacitor2.material = qPlus;
            h2.SetActive(true);
            mgh.SetActive(true);
        }
        if (timeValue >= 24 && !a[2])
        {
            a[2] = true;
            rl.destRotation = _34T14T;
            mol3.destPoint = fDestPointEnd;
            mol4.enabled = true;
            molg.destPoint = p3dp;
            cable2.material = qStream2;
            capacitor1.material = capacitorMat;
            capacitor2.material = capacitorMat;
            h2.SetActive(false);
            mgh.SetActive(false);
        }
        if (timeValue >= 24)
        {
            if (Input.GetKeyUp(KeyCode.Tab))
            {
                tab++;
            }
            if (Input.GetKeyUp(KeyCode.Space))
            {
                o++;
            }
            if (o >= 7 && tab >= o && !hda)
            {
                hda = true;
                pause = music.GetComponent<PauseDemo>();
                audioS = music.GetComponent<AudioSource>();
                if (pause.paused)
                {
                    audioS.UnPause();
                    Time.timeScale = 1;
                }
                Destroy(music);
                SceneManager.LoadScene(12);
            }
        }
        if (timeValue >= 32 && !a[3])
        {
            a[3] = true;
            rl.destRotation = _0T;
            mol4.destPoint = fDestPointEnd;
            mol5.enabled = true;
            molg.destPoint = p4dp;
            cable2.material = cableMat;
            capacitor1.material = qPlus;
            capacitor2.material = qMinus;
            h1.SetActive(true);
        }
        if (timeValue >= 45 && !a[4])
        {
            a[4] = true;
            bm = GameObject.FindGameObjectWithTag("BMAgent");
            if (bm != null)
            {
                bmagent = bm.GetComponent<BenchmarkAgent>();
                bmagent.CalculateAverageFPS();
            }
            SceneManager.LoadScene(5);
        }
    }
}
