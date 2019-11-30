using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hover : MonoBehaviour
{
    public static SpriteRenderer AreaRange;
    public float x;
    public float y;
    private void Update()
    {
        FollowMouse(); 
    }
    private void Awake()
    {
        AreaRange =transform.GetChild(0).GetComponent<SpriteRenderer>();
    }
    void FollowMouse()
    {
        
        TowerBTN TB = GameObject.FindObjectOfType<TowerBTN>();
        
        if (TB.spriterender.enabled)
        {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(transform.position.x, transform.position.y, 0);
            AreaRange.transform.localScale = new Vector3(x, y, 1f);
        }
        
    }
    
}
