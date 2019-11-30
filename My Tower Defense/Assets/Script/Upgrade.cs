using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrade : MonoBehaviour
{
    [Header("LVL1UPGRADE")]
    public int UpgradeDamageLVL1;
    public float UpgradeFireRateLVL1;
    public float UpgradeRangeLVL1;
    public float UpgradeSpeedLVL1;
    [Header("LVL2UPGRADE")]
    public int UpgradeDamageLVL2;
    public float UpgradeFireRateLVL2;
    public float UpgradeRangeLVL2;
    public float UpgradeSpeedLVL2;
    [Header("LVL3UPGRADE")]
    public int UpgradeDamageLVL3;
    public float UpgradeFireRateLVL3;
    public float UpgradeRangeLVL3;
    public float UpgradeSpeedLVL3;
    [Header("LVL4UPGRADE")]
    public int UpgradeDamageLVL4;
    public float UpgradeFireRateLVL4;
    public float UpgradeRangeLVL4;
    public float UpgradeSpeedLVL4;
    [Header("LVL5UPGRADE")]
    public int UpgradeDamageLVL5;
    public float UpgradeFireRateLVL5;
    public float UpgradeRangeLVL5;
    public float UpgradeSpeedLVL5;
    [Header("Others")]
    public GameObject UpgradePanel;
    public GameObject BtnPanel;
    public Image Up1;
    public Image Up2;
    public Image Up3;
    public Image Up4;
    public Image Up5;
    public Button upgrade2;
    public Button upgrade3;
    public Button upgrade4;
    public Button upgrade5;
    private int Price;
    private Soldier soldier;

    void OpenUpgrade()
    {
        UpgradePanel.SetActive(!UpgradePanel.activeSelf);
        BtnPanel.SetActive(!BtnPanel.activeSelf);
    }
    
    void CheckerUpdate()
    {
        if (soldier.CheckerUp1 == true)
        {

            Color32 fullcolor = new Color32(255, 0, 0, 255);
            Up1.color = fullcolor;
        }
        else
        {
            Color32 fullcolor = new Color32(255, 255, 255, 255);
            Up1.color = fullcolor;
        }
        if (soldier.CheckerUp2 == true)
        {

            Color32 fullcolor = new Color32(255, 0, 0, 255);
            Up2.color = fullcolor;
        }
        else
        {
            Color32 fullcolor = new Color32(255, 255, 255, 255);
            Up2.color = fullcolor;
        }
        if (soldier.CheckerUp3 == true)
        {

            Color32 fullcolor = new Color32(255, 0, 0, 255);
            Up3.color = fullcolor;
        }
        else
        {
            Color32 fullcolor = new Color32(255, 255, 255, 255);
            Up3.color = fullcolor;
        }
        if (soldier.CheckerUp4 == true)
        {

            Color32 fullcolor = new Color32(255, 0, 0, 255);
            Up4.color = fullcolor;
        }
        else
        {
            Color32 fullcolor = new Color32(255, 255, 255, 255);
            Up4.color = fullcolor;
        }
        if (soldier.CheckerUp5 == true)
        {

            Color32 fullcolor = new Color32(255, 0, 0, 255);
            Up5.color = fullcolor;
        }
        else
        {
            Color32 fullcolor = new Color32(255, 255, 255, 255);
            Up5.color = fullcolor;
        }

    }
    public void SelectSoldier(Soldier selectedSoldier)
    {
        if (soldier != null)
        {
            OpenUpgrade();
            
        }
        soldier = selectedSoldier;
        OpenUpgrade();
        CheckerUpdate();
        
    }
    public void DeselectSoldier()
    {
        if (soldier != null)
        {
            OpenUpgrade();
            
        }
        soldier = null;
        
    }
    public void AllStats20(int presyo)
    {
        GameManager GM = GameObject.FindObjectOfType<GameManager>();
        Price = presyo;
        if (soldier.CheckerUp1==false && Price<=GM.Gold)
        {
            GM.Gold -= Price;
            soldier.Damage += UpgradeDamageLVL1;
            soldier.fireRate += UpgradeFireRateLVL1;
            soldier.range += UpgradeRangeLVL1;
            soldier.Speed += UpgradeSpeedLVL1;
            soldier.CheckerUp1 = true;
            upgrade2.enabled = true;
        }
       if(soldier.CheckerUp1==true)
        {
           
            Color32 fullcolor = new Color32(255, 0, 0, 255);
            Up1.color = fullcolor;
        }
        
    }
    public void AllStats40(int presyo)
    {
        GameManager GM = GameObject.FindObjectOfType<GameManager>();
        Price = presyo;
        if (soldier.CheckerUp2 == false && Price <= GM.Gold && soldier.CheckerUp1!=false)
        {
            soldier.Damage += UpgradeDamageLVL2;
            soldier.fireRate += UpgradeFireRateLVL2;
            soldier.range += UpgradeRangeLVL2;
            soldier.Speed += UpgradeSpeedLVL2;
            GM.Gold -= Price;
            soldier.CheckerUp2 = true;
            soldier.CheckerUp1 = true;
            upgrade3.enabled = true;
        }
        if (soldier.CheckerUp2 == true)
        {
            
            Color32 fullcolor = new Color32(255, 0, 0, 255);
            Up2.color = fullcolor;
            Up1.color = fullcolor;
        }

    }
    public void AllStats60(int presyo)
    {
        GameManager GM = GameObject.FindObjectOfType<GameManager>();
        Price = presyo;
        if (soldier.CheckerUp3 == false && Price <= GM.Gold&&soldier.CheckerUp2 != false)
        {
            soldier.Damage += UpgradeDamageLVL3;
            soldier.fireRate += UpgradeFireRateLVL3;
            soldier.range += UpgradeRangeLVL3;
            soldier.Speed += UpgradeSpeedLVL3;
            GM.Gold -= Price;
            soldier.CheckerUp3 = true;
            soldier.CheckerUp2 = true;
            soldier.CheckerUp1 = true;
            upgrade4.enabled = true;
        }
        if (soldier.CheckerUp3 == true)
        {
            
            Color32 fullcolor = new Color32(255, 0, 0, 255);
            Up3.color = fullcolor;
            Up2.color = fullcolor;
            Up1.color = fullcolor;
        }

    }
    public void AllStats80(int presyo)
    {
        GameManager GM = GameObject.FindObjectOfType<GameManager>();
        Price = presyo;
        if (soldier.CheckerUp4 == false && Price <= GM.Gold && soldier.CheckerUp3 != false)
        {
            soldier.Damage += UpgradeDamageLVL4;
            soldier.fireRate += UpgradeFireRateLVL4;
            soldier.range += UpgradeRangeLVL4;
            soldier.Speed += UpgradeSpeedLVL4;
            GM.Gold -= Price;
            soldier.CheckerUp4 = true;
            soldier.CheckerUp3 = true;
            soldier.CheckerUp2 = true;
            soldier.CheckerUp1 = true;
            upgrade5.enabled = true;
        }
        if (soldier.CheckerUp4 == true)
        {
           
            Color32 fullcolor = new Color32(255, 0, 0, 255);
            Up4.color = fullcolor;
            Up3.color = fullcolor;
            Up2.color = fullcolor;
            Up1.color = fullcolor;
        }

    }
    public void AllStats100(int presyo)
    {
        GameManager GM = GameObject.FindObjectOfType<GameManager>();
        Price = presyo;
        if (soldier.CheckerUp5 == false && Price <= GM.Gold && soldier.CheckerUp4 != false)
        {
            soldier.Damage += UpgradeDamageLVL5;
            soldier.fireRate += UpgradeFireRateLVL5;
            soldier.range += UpgradeRangeLVL5;
            soldier.Speed += UpgradeSpeedLVL5;
            GM.Gold -= Price;
            soldier.CheckerUp5 = true;
            soldier.CheckerUp4 = true;
            soldier.CheckerUp3 = true;
            soldier.CheckerUp2 = true;
            soldier.CheckerUp1 = true;
        }
        if (soldier.CheckerUp5 == true)
        {
           
            Color32 fullcolor = new Color32(255, 0, 0, 255);
            Up5.color = fullcolor;
            Up4.color = fullcolor;
            Up3.color = fullcolor;
            Up2.color = fullcolor;
            Up1.color = fullcolor;
        }

    }
}
