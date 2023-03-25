
using UnityEngine;

public class MinoSpawner : MonoBehaviour
{
    public float spawnDelay = .3f;

    public GameObject minotaur;


    float nextTimeToSpawn = 0f;

    void SpawnMinotaur()
    {
        // Spawn Minotaur
        Instantiate(minotaur, transform.position, transform.rotation);
    
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
