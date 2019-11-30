using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public GameObject mySpriteRenderer;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Select()
    {
        mySpriteRenderer.SetActive(!mySpriteRenderer.activeSelf);
    }
    
}
