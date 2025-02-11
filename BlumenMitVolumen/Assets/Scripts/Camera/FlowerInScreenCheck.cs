
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerInScreenCheck : MonoBehaviour
{
    Vector3 cameraPos;
    Vector3 NEFlowerPos;
    Vector3 NWFlowerPos;
    Vector3 SEFlowerPos;
    Vector3 SWFlowerPos;

    public bool NorthEastInScreen()
    {
        NEFlowerPos = gameObject.transform.position;
        NEFlowerPos = new Vector3(NEFlowerPos.x + 1, NEFlowerPos.y + 1, 0);
        
        cameraPos = Camera.main.WorldToViewportPoint(NEFlowerPos);

        if(cameraPos.x > 1f || cameraPos.x < 0)
        {
            return false;
        }

        if(cameraPos.y > 1f || cameraPos.y < 0)
        {
            return false;
        }

        return true;
    }

    public bool NorthWestInScreen()
    {
        NWFlowerPos = gameObject.transform.position;
        NWFlowerPos = new Vector3(NWFlowerPos.x - 1, NWFlowerPos.y + 1, 0);
        
        cameraPos = Camera.main.WorldToViewportPoint(NWFlowerPos);

        if(cameraPos.x > 1f || cameraPos.x < 0)
        {
            return false;
        }

        if(cameraPos.y > 1f || cameraPos.y < 0)
        {
            return false;
        }

        return true;
    }

    public bool SouthEastInScreen()
    {
        SEFlowerPos = gameObject.transform.position;
        SEFlowerPos = new Vector3(SEFlowerPos.x + 1, SEFlowerPos.y - 1, 0);
        
        cameraPos = Camera.main.WorldToViewportPoint(SEFlowerPos);

        if(cameraPos.x > 1f || cameraPos.x < 0)
        {
            return false;
        }

        if(cameraPos.y > 1f || cameraPos.y < 0)
        {
            return false;
        }

        return true;
    }

    public bool SouthWestInScreen()
    {
        SWFlowerPos = gameObject.transform.position;
        SWFlowerPos = new Vector3(SWFlowerPos.x - 1, SWFlowerPos.y - 1, 0);
        
        cameraPos = Camera.main.WorldToViewportPoint(SWFlowerPos);

        if(cameraPos.x > 1f || cameraPos.x < 0)
        {
            return false;
        }

        if(cameraPos.y > 1f || cameraPos.y < 0)
        {
            return false;
        }

        return true;
    }

    public bool InCameraView()
    {
        if(NorthEastInScreen() || NorthWestInScreen() || SouthEastInScreen() || SouthWestInScreen())
        {
            return true;
        }

        return false;
    }
}
