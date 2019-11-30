using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sell : MonoBehaviour
{
   
    public void Selling()
    {
        GameManager GM = GameObject.FindObjectOfType<GameManager>();
        GM.Sell();
      
    }
}
