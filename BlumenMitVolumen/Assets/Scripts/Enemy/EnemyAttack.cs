using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] bool attacking;
    [SerializeField] float timer;
    [SerializeField] float attackDelay = 2; // Time between attacks [s]
    [SerializeField] float damage = 1; // Damage/attack

    // Update is called once per frame
    void Update()
    {
        if(attacking)
        {
            timer += Time.deltaTime;
            if(timer >= attackDelay)
            {
                FlowerHealth.instance.currentLife -= damage;
                timer = 0;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        if(collider.gameObject.tag == "Flower")
        {
            attacking = true;
        }
    }

    void OnCollisionExit2D(Collision2D collider)
    {
        if(collider.gameObject.tag == "Flower")
        {
            attacking = false;
        }
    }
}