using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemy : MonoBehaviour
{
    [SerializeField] GameObject mineralsPrefab;
    [SerializeField] ParticleSystem particleSys;

    [SerializeField] float enemyHP = 10f;
    [SerializeField] float onClickDamage = 2.5f;

    int roll;
    [SerializeField] int spawnChance = 35; // int 1-100

    private void OnMouseDown()
    {
        enemyHP -= onClickDamage;
        if (enemyHP <= 0)
        {
            EnemyDeath();
        }
    }

    void EnemyDeath()
    {
        CheckMineralSpawnRate();
        Instantiate(particleSys, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    void CheckMineralSpawnRate()
    {
        roll = Random.Range(1, 101);
        if(roll <= spawnChance)
        {
            SpawnMineral();
        }
    }

    void SpawnMineral()
    {
        Instantiate(mineralsPrefab, transform.position, Quaternion.Euler(0, 0, Random.Range(0, 360)));
    }
}
