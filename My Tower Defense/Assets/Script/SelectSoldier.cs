using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectSoldier : MonoBehaviour
{
    public static SpriteRenderer AreaRange;

    private void Awake()
    {
        AreaRange = GetComponent<SpriteRenderer>();
    }

    
}
