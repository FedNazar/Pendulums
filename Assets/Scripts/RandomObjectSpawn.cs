using UnityEngine;

public class RandomObjectSpawn : MonoBehaviour
{
    public Transform[] spawns;
    public GameObject[] objects;
    float timeValue = 0;
    public float maxRespawnTime = 7f, minRespawnTime = 1f;
    float respawnTime;
    int spawnNum;

    void Start()
    {
        respawnTime = Random.Range(minRespawnTime, maxRespawnTime);
    }

    void Update()
    {
        timeValue += Time.deltaTime;
        if (timeValue >= respawnTime)
        {
            spawnNum = Random.Range(0, 4);
            Instantiate(objects[0], spawns[spawnNum].position, objects[0].transform.rotation);
            respawnTime = Random.Range(minRespawnTime, maxRespawnTime);
            timeValue = 0;
        }
    }
}
