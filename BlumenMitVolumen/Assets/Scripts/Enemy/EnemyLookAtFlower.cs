using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyLookAtFlower : MonoBehaviour
{
    [SerializeField] Transform enemy;
    Vector2 enemyPos;
    Vector2 flowerPos;
    float enemyAngle;

    void Awake()
    {
        flowerPos = new Vector2(0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        enemyPos = gameObject.transform.position;
        
        enemyAngle = Mathf.Atan2(enemyPos.x, enemyPos.y) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(enemyAngle - 90, Vector3.forward);
        enemy.rotation = rotation;
        if(Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log(rotation);
        }
    }
}
