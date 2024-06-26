using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerStages : MonoBehaviour
{
    [SerializeField] float firstStageChange = 0.75f;
    [SerializeField] float secondStageChange = 0.25f;

    [SerializeField] SpriteRenderer flowerSr;
    [SerializeField] Sprite badFlower;
    [SerializeField] Sprite worstFlower;

    // Update is called once per frame
    void Update()
    {
        if(FlowerHealth.instance.currentLife <= FlowerHealth.instance.maxLife * firstStageChange
            && FlowerHealth.instance.currentLife > FlowerHealth.instance.maxLife * secondStageChange)
        {
            flowerSr.sprite = badFlower;
        }
        else if(FlowerHealth.instance.currentLife <= FlowerHealth.instance.maxLife * secondStageChange)
        {
            flowerSr.sprite = worstFlower;
        }
    }
}
