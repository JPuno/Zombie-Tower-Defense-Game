using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evaluate : MonoBehaviour
{
    public int evaluatePathA;
    public string Tagg;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag(Tagg))
        {
            Debug.Log(collision.name);
            evaluatePathA++;
            
        }
        

    }
}
