using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class KillEnemy : MonoBehaviour
{
    [SerializeField] GameObject mineralsPrefab;
    [SerializeField] ParticleSystem particleSys;

    [SerializeField] float enemyHP = 10f;
    [SerializeField] float onClickDamage = 2.5f;

    private void OnMouseDown()
    {
        enemyHP -= onClickDamage;
        if (enemyHP <= 0)
        {
            Instantiate(mineralsPrefab, transform.position, Quaternion.Euler(0, 0, Random.Range(0, 360)));
            Instantiate(particleSys, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
