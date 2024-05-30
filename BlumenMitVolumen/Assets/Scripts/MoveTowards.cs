using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowards : MonoBehaviour
{
    public float speed = 1f;

    private Vector2 target;
    private Vector2 position;
    public GameObject targetObject;


    // Start is called before the first frame update
    void Start()
    {
        target = targetObject.transform.position;
        position = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;

        transform.position = Vector2.MoveTowards(transform.position, target, step);
    }
}
