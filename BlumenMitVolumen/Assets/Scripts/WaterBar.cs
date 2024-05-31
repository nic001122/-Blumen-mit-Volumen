using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterBar : MonoBehaviour
{
    public int maxWaterBar = 100;
    public int currentWaterBar;
    public float damageBarrier;
    public float damage;
    public int damageMultiplier = 1; // Wie viel Schaden Hinzugefügt wird (muss int sein)
    public int damageDelay = 1; // Wie viele Sekunden vorbei gehen müssen für Schaden (muss int sein)
    int damageInt;
    [SerializeField] DamageEnemy damageEnemy;

    // Start is called before the first frame update
    void Awake()
    {
        currentWaterBar = maxWaterBar;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentWaterBar <= damageBarrier)
        {
            damage += Time.deltaTime;
            if(damage >= damageDelay)
            {
                damageInt = Mathf.RoundToInt(damage);
                damageEnemy.currentLife -= damageInt * damageMultiplier;
                damage = 0;
            }
        }
    }
}
