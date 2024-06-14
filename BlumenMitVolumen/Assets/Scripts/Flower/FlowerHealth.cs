using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlowerHealth : MonoBehaviour
{
    public static FlowerHealth instance {get; set;}

    void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }



    public float maxLife = 100;
    public float currentLife;

    void Start()
    {
        currentLife = maxLife;
    }

    void Update()
    {
        if(currentLife >= maxLife)
        {
            currentLife = maxLife;
        }
        if(currentLife <= 0)
        {
            SceneManager.LoadScene(2);
        }
    }
}