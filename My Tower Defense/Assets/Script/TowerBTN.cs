using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerBTN : MonoBehaviour
{
    
    public GameObject towerPrefab;
    public SpriteRenderer spriterender;
    public Sprite sprite;
    public static int Price;
    public int displayPrice;
    public Text Displayprice;
    private void Update()
    {
        HandleESC();
    }
    private void Awake()
    {
        Displayprice.text = displayPrice.ToString();
    }
    public void PickTower(int presyo)
    {
        GameManager GM = GameObject.FindObjectOfType<GameManager>();
       Price = presyo;
        if (GM.Gold >= presyo)
        {
            TowerSpawn.TowerPrefab = towerPrefab;
            spriterender.sprite = sprite;
            spriterender.enabled = true;
            Hover.AreaRange.enabled = true;
        }
        
    }
    public void DeactivateSprite()
    {
        spriterender.enabled = false;
        Hover.AreaRange.enabled = false;
        TowerSpawn.TowerPrefab = null;
    }
    private void HandleESC()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            DeactivateSprite();
        }
    }
    public void ShowInfoSoldierName(string soldierName)
    {
        GameManager GM = GameObject.FindObjectOfType<GameManager>();
        GM.SetToolTipSoldierName(soldierName);
        GM.ShowStats();
    }
    public void ShowInfoRange( string range)
    {
        GameManager GM = GameObject.FindObjectOfType<GameManager>();
        GM.SetToolTipRange( range);
        GM.ShowStats();
    }
    public void ShowInfoDamage( string damage)
    {
        GameManager GM = GameObject.FindObjectOfType<GameManager>();
        GM.SetToolTipDamage( damage);
        GM.ShowStats();
    }
    public void ShowInfoSpeed( string speed)
    {
        GameManager GM = GameObject.FindObjectOfType<GameManager>();
        GM.SetToolTipSpeed( speed);
        GM.ShowStats();
    }
    public void AreaRangeX(float x)
    {
        Hover h = GameObject.FindObjectOfType<Hover>();
        h.x = x;
    }
    public void AreaRangeY(float y)
    {
        Hover h = GameObject.FindObjectOfType<Hover>();
        h.y = y;
    }
}
