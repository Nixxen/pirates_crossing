
using UnityEngine;

public class MinoSpawner : MonoBehaviour
{
    public float spawnDelay = .3f;

    public GameObject minotaur;

    public Transform[] spawnPoints;

    float nextTimeToSpawn = 0f;

    void SpawnMinotaur()
    {
        // Select random spawn
        int spawnIndex = Random.Range(0, spawnPoints.Length);
        // Spawn Minotaur
        Instantiate(minotaur, spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
    
    }


    void Update ()
    {
        if (nextTimeToSpawn <= Time.time)
        {
            SpawnMinotaur();
            nextTimeToSpawn = Time.time + spawnDelay;
        }

    }

}
