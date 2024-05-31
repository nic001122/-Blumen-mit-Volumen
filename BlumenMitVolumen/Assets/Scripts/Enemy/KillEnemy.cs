using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemy : MonoBehaviour
{
    [SerializeField] GameObject mineralsPrefab;
    [SerializeField] float enemyHP = 10f;
    [SerializeField] float onClickDamage = 2.5f;

    private void OnMouseDown()
    {
        enemyHP -= onClickDamage;
        if (enemyHP <= 0)
        {
            Instantiate(mineralsPrefab, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}