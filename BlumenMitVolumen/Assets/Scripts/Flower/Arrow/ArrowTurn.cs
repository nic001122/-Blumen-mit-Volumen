using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class ArrowTurn : MonoBehaviour
{
    float arrowAngle;

    // Update is called once per frame
    void Update()
    {
        if(gameObject.activeSelf)
        {
            arrowAngle = Mathf.Atan2(transform.position.y, transform.position.x) * Mathf.Rad2Deg; // Setzt Winkel fest
            Quaternion arrowRotation = Quaternion.AngleAxis(arrowAngle + 90, Vector3.forward); // Formattiert Winkel
            gameObject.transform.rotation = arrowRotation; // Implementiert Winkel auf Objekt
        }
    }
}
