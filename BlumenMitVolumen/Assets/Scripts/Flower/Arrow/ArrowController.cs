using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    [SerializeField] FlowerInScreenCheck flowerInScreenCheck;

    Vector3 mousePos;

    [SerializeField] GameObject arrow;

    // Update is called once per frame
    void Update()
    {
        if(arrow.activeSelf)
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z += 10;
            arrow.gameObject.transform.position = mousePos;
        }
    }
}
