using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SeedTimer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI seedTimer;

    public float mineralDecrease = 10;
    public float timerLength = 300;
    [SerializeField] int timerLengthInt;

    // Update is called once per frame
    void Update()
    {
        timerLength -= Time.deltaTime;
        timerLengthInt = Mathf.RoundToInt(timerLength);
        seedTimer.text = timerLengthInt.ToString();
    }
}
