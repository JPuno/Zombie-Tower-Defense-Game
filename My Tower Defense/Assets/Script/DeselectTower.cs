using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DeselectTower : MonoBehaviour
{
    private void OnMouseOver()
    {
        if (!EventSystem.current.IsPointerOverGameObject() && TowerSpawn.TowerPrefab == null && Input.GetMouseButtonDown(0))
        {
            GameManager GM = GameObject.FindObjectOfType<GameManager>();
            Upgrade UP = GameObject.FindObjectOfType<Upgrade>();
            UP.DeselectSoldier();
            GM.DeselectTower();
            
        }
    }
}
