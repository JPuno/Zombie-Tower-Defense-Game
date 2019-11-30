using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom1 : MonoBehaviour
{
    public float zoomSize;
   
    void Update()
    {
       
        if (Input.GetAxis("Mouse ScrollWheel")>0)
        {
            if(zoomSize>=6.2)
            zoomSize -= 1;
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            if (zoomSize <=8.1)
                zoomSize += 1;
        }
        GetComponent<Camera>().orthographicSize = zoomSize;
    }
}
