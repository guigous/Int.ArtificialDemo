using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnFrequency = 3f;
    

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0f, spawnFrequency);
        
    }

    void SpawnEnemy()
    {
        
        Instantiate(enemyPrefab, this.transform.position, Quaternion.identity);
    }
}
