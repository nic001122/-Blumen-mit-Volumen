using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    [SerializeField] bool aboveWater;
    [SerializeField] bool aboveFlower;
    bool filled;
    [SerializeField] Sprite emptyBucket;
    [SerializeField] Sprite fullBucket;
    [SerializeField] SpriteRenderer bucketsr;
    
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

    void fillBucket()
    {
        filled = true;
        bucketsr.sprite = fullBucket;
    }

    void wateringFlower()
    {
        filled = false;
        bucketsr.sprite = emptyBucket;
    }
}