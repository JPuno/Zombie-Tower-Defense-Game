using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evaluate3 : MonoBehaviour
{
    public int evaluatePathD;
    public string Tagg;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag(Tagg))
        {
            Debug.Log(collision.name);
            evaluatePathD++;

        }


    }
}
