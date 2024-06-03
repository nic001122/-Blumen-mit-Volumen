using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class WaterBar : MonoBehaviour
{
    [SerializeField] DamageEnemy damageEnemy;

    public float currentWater;
    [SerializeField] int currentWaterInt;
    public float maxWater = 500;
    [SerializeField] float damageBarrier;
    float damage;
    [SerializeField] int damageDelay = 1; // Wie viele Sekunden vergehen bis man Schaden bekommt (int)
    [SerializeField] int damageMultiplier = 1; // Wie viel Schaden man pro delay-Sekunden bekommt (int)
    int damageInt;


    [SerializeField] RectTransform barRect;
    [SerializeField] RectMask2D mask;
    
    float maxRightMask;
    float initialRightMask;

    void Start()
    {
        currentWater = maxWater;
        maxRightMask = barRect.rect.width - mask.padding.x - mask.padding.y;
        initialRightMask = mask.padding.z;
    }

    void Update()
    {
        currentWater -= Time.deltaTime;

        if(currentWater <= damageBarrier)
        {
            damage += Time.deltaTime;
            if(damage >= damageDelay)
            {
                damageInt = Mathf.RoundToInt(damage);
                damageEnemy.currentLife -= damageInt * damageMultiplier;
                damage = 0;
            }
        }

        if(currentWater <= 0)
        {
            currentWater = 0;
        }
        if(currentWater >= maxWater)
        {
            currentWater = maxWater;
        }

        currentWaterInt = Mathf.RoundToInt(currentWater);
        SetValue(currentWaterInt);
    }

    public void SetValue(int newValue)
    {
        var targetWidth = newValue * maxRightMask / maxWater;
        var newRightMask = maxRightMask + initialRightMask - targetWidth;
        var padding = mask.padding;
        padding.z = newRightMask;
        mask.padding = padding;
    }
}
