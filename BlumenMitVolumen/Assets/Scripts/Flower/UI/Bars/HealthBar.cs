using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
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
        SetValue(FlowerHealth.instance.currentLife);
    }

    public void SetValue(float newValue)
    {
        var targetWidth = newValue * maxRightMask / FlowerHealth.instance.maxLife;
        var newRightMask = maxRightMask + initialRightMask - targetWidth;
        var padding = mask.padding;
        padding.z = newRightMask;
        
        mask.padding = padding;
    }
}
