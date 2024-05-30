using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BucketController : MonoBehaviour
{
    Vector2 mousePos;
    Vector2 bucketStartPos;

    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if(Input.GetKeyDown(KeyCode.E))
        {
            if(aboveWater)
            {
                fillBucket();
            }
        }
    }

    void OnMouseDrag()
    {
        gameObject.transform.position = mousePos;
    }

    void OnMouseUp()
    {
        gameObject.transform.position = bucketStartPos;
    }

    void Awake()
    {
        bucketStartPos = gameObject.transform.position;
    }

    bool aboveWater;
    bool filled;
    [SerializeField] Sprite emptyBucket;
    [SerializeField] Sprite fullBucket;
    [SerializeField] SpriteRenderer bucketsr;
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        aboveWater = true;
        Debug.Log(aboveWater);
    }

    void fillBucket()
    {
        filled = true;
        bucketsr.sprite = fullBucket;
    }
}