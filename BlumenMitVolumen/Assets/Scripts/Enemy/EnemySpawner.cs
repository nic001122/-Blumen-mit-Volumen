using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject spawnLocation;
    [SerializeField] float enemySpawnRadius = 50;
    [SerializeField] float noEnemyRadius = 25;

    [SerializeField]private float interval;
    private float count = 0f;


    // Update is called once per frame
    private void Update()
    {
        count += Time.deltaTime;
        
        if (count >= interval)
        {
            count = 0f;
            CheckSpawnLocation();
        }
    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnLocation.transform.position, transform.rotation);
    }

    void CheckSpawnLocation()
    {
        spawnLocation.transform.position = Random.insideUnitCircle * enemySpawnRadius;

        if(spawnLocation.transform.position.x <= noEnemyRadius && spawnLocation.transform.position.y <= noEnemyRadius)
        {
            CheckSpawnLocation();
        }
        else
        {
            SpawnEnemy();
        }
    }
}
