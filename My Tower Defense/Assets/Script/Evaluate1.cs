using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evaluate1 : MonoBehaviour
{
    public int evaluatePathB;
    public string Tagg;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag(Tagg))
        {
            Debug.Log(collision.name);
            evaluatePathB++;

        }


    }
}
