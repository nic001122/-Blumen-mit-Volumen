using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineralController : MonoBehaviour
{
    [HideInInspector] public Rigidbody2D rb2d;

    void OnMouseDown()
    {
        SeedTimer.Instance.timerLength -= SeedTimer.Instance.mineralDecrease;
        Destroy(gameObject);
    }

    void Awake()
    {
        Vector2 force = Random.insideUnitCircle * 3;

        rb2d = GetComponent<Rigidbody2D>();
        rb2d.AddForce(force, ForceMode2D.Impulse);
    }
}
