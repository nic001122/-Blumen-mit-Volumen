using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineralController : MonoBehaviour
{
    void OnMouseDown()
    {
        SeedTimer.Instance.timerLength -= SeedTimer.Instance.mineralDecrease;
        Destroy(gameObject);
    }
}
