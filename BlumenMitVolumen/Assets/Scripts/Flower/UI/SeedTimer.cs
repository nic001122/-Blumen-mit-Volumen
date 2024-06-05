using System;
using System.Collections;
using TMPro;
using UnityEngine;

public class SeedTimer : MonoBehaviour
{
    public static SeedTimer Instance {get; set;}

    void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

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
