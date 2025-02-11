using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ArrowAlphaController : MonoBehaviour
{
    [SerializeField] SpriteRenderer arrowRenderer;
    float minDistance = 5f;
    float maxDistance = 15f;
    float distance;
    float normalizedDistance;

    Vector3 flowerPos;

    // Start is called before the first frame update
    void Start()
    {
        flowerPos = transform.parent.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(gameObject.transform.position, flowerPos);

        normalizedDistance = (distance - minDistance) / (maxDistance - minDistance);

        arrowRenderer.color = new Color(255, 255, 255, 0 + normalizedDistance);
    }
}
