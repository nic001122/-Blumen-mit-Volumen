using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEnemy : MonoBehaviour
{
    private float timer = 0f;
    private float timeLimit = 2f;


    private bool isAttacking = false;
    private int maxLife = 100;
    [SerializeField]private int currentLife = 0;

    private void Start()
    {
        currentLife = maxLife;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isAttacking = true;
        

    }
    private void Update()
    {
        timer += Time.deltaTime;


        if (isAttacking)
        {
            if (timer >= timeLimit)
            {
                currentLife -= 2;
                timer = 0f;
            }
        }
        if (currentLife <= 0)
        {
            Destroy(gameObject);
        }
    }
}
