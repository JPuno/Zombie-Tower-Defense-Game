using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TileScript : MonoBehaviour
{
    private Color32 fullcolor = new Color32(255, 0, 0, 255);
    private Color32 emptyColor = new Color32(96, 255, 90, 255);
    private Color32 colorExit = new Color32(36,33,33,255);
    private SpriteRenderer spriterender;
    public bool isEmpty = true;
    private Tower mytower;
    private TileScript mytileScript;
    private Soldier mysoldier;
    public TileScript mytile=null;
    public GameObject soldier=null;
    private void Start()
    {
        spriterender = GetComponent<SpriteRenderer>();
        
    }
    private void Update()
    {
        HandleEsc();

    }
    void HandleEsc()
    {
        Upgrade Up = GameObject.FindObjectOfType<Upgrade>();
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GameManager GM = GameObject.FindObjectOfType<GameManager>();
            GM.DeselectTower();
            Up.DeselectSoldier();
        }
    }
    private void OnMouseOver()
    {
        GameManager GM = GameObject.FindObjectOfType<GameManager>();
        Upgrade Up = GameObject.FindObjectOfType<Upgrade>();
        TowerBTN TB = GameObject.FindObjectOfType<TowerBTN>();
      
        colorTile(Color.blue);
        if (!EventSystem.current.IsPointerOverGameObject() && TowerSpawn.TowerPrefab != null)
        {
            if (isEmpty)
            {
                colorTile(emptyColor);
            }
            if (!isEmpty)
            {
                colorTile(fullcolor);
            }
            else if (Input.GetMouseButtonDown(0))
            {
                PlaceTower();
                GM.Gold -= TowerBTN.Price;
                TB.DeactivateSprite();
            }
        }
       else if (!EventSystem.current.IsPointerOverGameObject() && TowerSpawn.TowerPrefab == null && Input.GetMouseButtonDown(0))
        {
            if(mytower != null&& mysoldier!=null)
            {
                
                GM.SelectTower(mytower,mytile);
                Up.SelectSoldier(mysoldier);
               

            }
            else 
            {
                
                GM.DeselectTower();
                Up.DeselectSoldier();
               
            }
            
        }
       
     
    }
    private void OnMouseExit()
    {
        colorTile(colorExit);
    }
   
    void PlaceTower()
    {
        isEmpty = false;
        soldier = Instantiate(TowerSpawn.TowerPrefab, transform.position, Quaternion.identity);
        soldier.transform.SetParent(transform);
        GameManager.BuyTower();
        colorTile(colorExit);
        mytower = soldier.transform.GetChild(0).GetComponent<Tower>();
        mysoldier = soldier.GetComponent<Soldier>();
        mytile = this;
        
    }
    void colorTile(Color newColor)
    {
        spriterender.color = newColor;
    }
   
    

}
