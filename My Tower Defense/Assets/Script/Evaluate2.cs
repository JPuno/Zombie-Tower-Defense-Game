using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evaluate2 : MonoBehaviour
{
    public int evaluatePathC;
    public string Tagg;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag(Tagg))
        {
            Debug.Log(collision.name);
            evaluatePathC++;

        }


    }
}
