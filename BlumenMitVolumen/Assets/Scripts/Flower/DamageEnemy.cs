using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DamageEnemy : MonoBehaviour
{
    private float timer = 0f;
    private float timeLimit = 2f;


    public bool isAttacking;
    public int maxLife = 100;
    public int currentLife = 0;

    private void Start()
    {
        currentLife = maxLife;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isAttacking = true;
    }

    void OnCollisionExit2D()
    {
        isAttacking = false;
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
            SceneManager.LoadScene(2);
            Destroy(gameObject);
        }
    }
}
