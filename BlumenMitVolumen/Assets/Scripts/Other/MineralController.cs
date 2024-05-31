using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderKeywordFilter;
using UnityEngine;

public class MineralController : MonoBehaviour
{
    [SerializeField] GameObject timer;
    [SerializeField] float seedTimer;
    [SerializeField] float mineralDecrease;

    void Update()
    {
        seedTimer = timer.GetComponent<SeedTimer>().timerLength;
        mineralDecrease = timer.GetComponent<SeedTimer>().mineralDecrease;
    }

    void OnMouseDown()
    {
        seedTimer -= mineralDecrease;
        Destroy(gameObject);
    }
}
