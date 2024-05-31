using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] DamageEnemy damageEnemy;
    [SerializeField] Slider healthBar;

    // Start is called before the first frame update
    void Start()
    {
        healthBar.maxValue = damageEnemy.maxLife;    
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.value = damageEnemy.currentLife;   
    }
}
