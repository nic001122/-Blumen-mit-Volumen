using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLookAtFlower : MonoBehaviour
{
    [SerializeField] Transform enemy;
    [SerializeField] float enemyAngle;

    // Update is called once per frame
    void Update()
    {
        enemyAngle = Mathf.Atan2(transform.position.y, transform.position.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(enemyAngle - 180, Vector3.forward);
        enemy.rotation = rotation;
    }
}
