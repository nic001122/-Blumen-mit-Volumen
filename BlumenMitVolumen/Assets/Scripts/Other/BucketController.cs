using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketController : MonoBehaviour
{
    Vector2 mousePos;
    Vector2 bucketStartPos;

    [SerializeField] bool aboveWater;
    [SerializeField] bool aboveFlower;

    [SerializeField] Sprite emptyBucket;
    [SerializeField] Sprite fullBucket;
    [SerializeField] SpriteRenderer bucketsr;

    [SerializeField] WaterBar waterBar;
    [SerializeField] float waterReplenishAmount;

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

        if(Input.GetKeyDown(KeyCode.F))
        {
            if(aboveFlower)
            {
                wateringFlower();
            }
        }
    }

    bool canDrag = true;

    void OnMouseDrag()
    {
        if(canDrag)
        {
            gameObject.transform.position = mousePos;
        }
    }

    void OnMouseUp()
    {
        resetBucketPos();
    }

    void resetBucketPos()
    {
        aboveWater = false;
        canDrag = true;
        gameObject.transform.position = bucketStartPos;
    }

    void Awake()
    {
        bucketStartPos = gameObject.transform.position;
    }


    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Water")
        {
            aboveWater = true;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            canDrag = false;
            gameObject.transform.position = bucketStartPos;
        }

        if(collision.gameObject.tag == "Flower")
        {
            aboveFlower = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Water")
        {
            aboveWater = false;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Flower")
        {
            aboveFlower = false;
        }
    }

    void fillBucket()
    {
        bucketsr.sprite = fullBucket;
    }

    void wateringFlower()
    {
        waterBar.currentWaterBar += waterReplenishAmount;
        bucketsr.sprite = emptyBucket;
    }
}