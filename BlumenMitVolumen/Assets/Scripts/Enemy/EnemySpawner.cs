using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject EnemyPrefab;
    [SerializeField]private float interval = 2f;
    private float count = 0f;


    // Update is called once per frame
    private void Update()
    {
        count += Time.deltaTime;
        
        if (count >= interval)
        {
            count = 0f;
            Instantiate(EnemyPrefab, transform.position, transform.rotation);
        }
    }
}
