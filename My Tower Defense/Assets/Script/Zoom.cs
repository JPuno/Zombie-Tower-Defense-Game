using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    public float zoomSize;
   
    void Update()
    {
       
        if (Input.GetAxis("Mouse ScrollWheel")>0)
        {
            if(zoomSize>=22.6)
            zoomSize -= 1;
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            if (zoomSize <=29.6)
                zoomSize += 1;
        }
        GetComponent<Camera>().orthographicSize = zoomSize;
    }
}
