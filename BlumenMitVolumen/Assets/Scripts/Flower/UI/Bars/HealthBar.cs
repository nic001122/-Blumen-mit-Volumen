using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] DamageEnemy damageEnemy;

    [SerializeField] RectTransform barRect;

    [SerializeField] RectMask2D mask;

    float maxRightMask;
    float initialRightMask;

    // Start is called before the first frame update
    void Start()
    {
        maxRightMask = barRect.rect.width - mask.padding.x - mask.padding.z;
        initialRightMask = mask.padding.z;
    }

    // Update is called once per frame
    void Update()
    {
        SetValue(damageEnemy.currentLife);
    }

    public void SetValue(int newValue)
    {
        var targetWidth = newValue * maxRightMask / damageEnemy.maxLife;
        var newRightMask = maxRightMask + initialRightMask - targetWidth;
        var padding = mask.padding;
        padding.z = newRightMask;
        
        mask.padding = padding;
    }
}
