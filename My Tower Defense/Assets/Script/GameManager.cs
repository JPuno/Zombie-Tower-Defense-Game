using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    private Tower towerSelect;
    public TileScript tile;
    public GameObject statsPanel;
    public GameObject GameOver;
    public Text SoldierName;
    public Text Damage;
    public Text Range;
    public Text Speed;
    public int Gold;
    public int Score;
    public Text DisplayGold;
    public Text DisplayScore;
    public Text WinDisplayScore;
    public Text DisplayGameOVerScore;
   // public AudioSource Scream;
    public Text Name;
    public GameObject WinWin;
    public int stage;
    
    

    private void Awake()
    {
       DataManager DM = GameObject.FindObjectOfType<DataManager>();
       Name.text = DM.Name;
       
       
    }
    private void Update()
    {
        DisplayGold.text = Gold.ToString();
        DisplayScore.text = Score.ToString();
        DisplayGameOVerScore.text = "Score " + Score;
        WinDisplayScore.text = "Score " + Score;
        GameeOver();
        Winner();
    }
    public static void BuyTower()
    {
        TowerBTN TB = GameObject.FindObjectOfType<TowerBTN>();
        TB.DeactivateSprite();
        
    }
    public  void SelectTower(Tower tower , TileScript mytile)
    {
        Hover h = GameObject.FindObjectOfType<Hover>();
        if (towerSelect != null)
        {
            towerSelect.Select();
        }
        h.enabled = false;
        towerSelect = tower;
        towerSelect.Select();
        tile = mytile;
    }
    public void DeselectTower()
    {
        Hover h = GameObject.FindObjectOfType<Hover>();
        if (towerSelect != null)
        {
            towerSelect.Select();
           
        }
        h.enabled = true;
        towerSelect = null;
        tile = null;

    }
    public void Sell()
    {
        if (towerSelect != null)
        {
            towerSelect.GetComponentInParent<TileScript>();
            Destroy(towerSelect.transform.parent.gameObject);
            tile.GetComponent<TileScript>();
            tile.isEmpty = true;
            Upgrade UP = GameObject.FindObjectOfType<Upgrade>();
            UP.DeselectSoldier();
            DeselectTower();
            Gold += 50;
        }
    }
    public void ShowStats()
    {
        statsPanel.SetActive(!statsPanel.activeSelf);
    }
    public void SetToolTipSoldierName(string soldierName)
    {
        SoldierName.text = soldierName;
        
    }
    public void SetToolTipRange( string range)
    {
      
        Range.text = "Range:" + range;
        
    }
    public void SetToolTipDamage( string damage)
    {
       
        Damage.text = "Damage:" + damage;
       
    }
    public void SetToolTipSpeed( string speed)
    {
       
        Speed.text = "Fire Rate Speed:" + speed;
    }
    void GameeOver()
    {
        WaveSpawner w = GameObject.FindObjectOfType<WaveSpawner>();
        WaveSpawner1 w1 = GameObject.FindObjectOfType<WaveSpawner1>();
        WaveSpawner2[] w2 = GameObject.FindObjectsOfType<WaveSpawner2>();
        Enemy[] e1 = GameObject.FindObjectsOfType<Enemy>();
        Enemy2[] e2 = GameObject.FindObjectsOfType<Enemy2>();
        Enemy3[] e3 = GameObject.FindObjectsOfType<Enemy3>();
        EnemyBoss[] eb1 = GameObject.FindObjectsOfType<EnemyBoss>();
        EnemyBoss2[] eb2 = GameObject.FindObjectsOfType<EnemyBoss2>();
        EnemyBoss3[] eb3 = GameObject.FindObjectsOfType<EnemyBoss3>();
        Soldier[] s = GameObject.FindObjectsOfType<Soldier>();
        PlayerStats p = GameObject.FindObjectOfType<PlayerStats>();
        if (p.Lives<=0)
        {
            GameOver.SetActive(true);
            w.enabled = false;
            w1.enabled = false;
            for (int i = 0; i < w2.Length; i++)
            {
                w2[i].enabled = false;

            }
            for (int i = 0; i < e1.Length; i++)
            {
                e1[i].enabled = false;
            }
            for (int i = 0; i < e2.Length; i++)
            {
                e2[i].enabled = false;
            }
            for (int i = 0; i < e3.Length; i++)
            {
                e3[i].enabled = false;
            }
            for (int i = 0; i < eb1.Length; i++)
            {
                eb1[i].enabled = false;
            }
            for (int i = 0; i < eb2.Length; i++)
            {
                eb2[i].enabled = false;
            }
            for (int i = 0; i < eb3.Length; i++)
            {
                eb3[i].enabled = false;
            }
            for (int i = 0; i < s.Length; i++)
            {
                s[i].enabled = false;
            }
            return;
        }
    }
    void Winner()
    {
        WaveSpawner w = GameObject.FindObjectOfType<WaveSpawner>();
        WaveSpawner1 w1 = GameObject.FindObjectOfType<WaveSpawner1>();
        WaveSpawner2 w2 = GameObject.FindObjectOfType<WaveSpawner2>();
        PlayerStats p = GameObject.FindObjectOfType<PlayerStats>();
       
        if(stage == 1 && p.Lives>0&& w.Wavenumber==6 && w.EnemiesAlive1<=0 && w.EnemiesAlive2 <= 0 && w.BossAlive<=0 && w.BossAlive2<=0)
        {
            WinWin.SetActive(true);
            w.enabled = false;
            WinDisplayScore.text = "Score " + Score;
            Unlocker Un = GameObject.FindObjectOfType<Unlocker>();
            Un.unlockerlevel2();
            LevelManager.score1 = Score;
            
            
        }
       else if (stage == 2 && p.Lives > 0 && w.Wavenumber == 6 && w.EnemiesAlive1 <= 0 && w.EnemiesAlive2 <= 0 && w.BossAlive <= 0 && w.BossAlive2 <= 0)
        {
            WinWin.SetActive(true);
            w.enabled = false;
            WinDisplayScore.text = "Score " + Score;
            Unlocker Un = GameObject.FindObjectOfType<Unlocker>();
           
                Un.unlockerlevel3();
            LevelManager.score2 = Score;

        }
        else if (stage == 3 && p.Lives > 0 && w.Wavenumber == 6 && w.EnemiesAlive1 <= 0 && w.EnemiesAlive2 <= 0 && w.BossAlive <= 0 && w.BossAlive2 <= 0)
        {
            WinWin.SetActive(true);
            w.enabled = false;
            WinDisplayScore.text = "Score " + Score;
            Unlocker Un = GameObject.FindObjectOfType<Unlocker>();
                Un.unlockerlevel4();
            LevelManager.score3 = Score;


        }
        else if (stage == 4 && p.Lives > 0 && w.Wavenumber == 6 && w.EnemiesAlive1 <= 0 && w.EnemiesAlive2 <= 0 && w.BossAlive <= 0 && w.BossAlive2 <= 0)
        {
            WinWin.SetActive(true);
            w.enabled = false;
            WinDisplayScore.text = "Score " + Score;
            Unlocker Un = GameObject.FindObjectOfType<Unlocker>();
                Un.unlockerlevel5();
            LevelManager.score4 = Score;


        }
        else if (stage == 5 && p.Lives > 0 && w1.Wavenumber == 6 && w1.EnemiesAlive1 <= 0 && w1.EnemiesAlive2 <= 0 && w1.EnemiesAlive3 <= 0 && w1.BossAlive <= 0 && w1.BossAlive2 <= 0 && w1.BossAlive3 <= 0 )
        {
            WinWin.SetActive(true);
            w1.enabled = false;
            WinDisplayScore.text = "Score " + Score;
            Unlocker Un = GameObject.FindObjectOfType<Unlocker>();
            Un.unlockerlevel6();
            LevelManager.score5 = Score;

        }
        else if (stage==6&& p.Lives > 0 && w2.Wavenumber == 6 && w2.EnemiesAlive1 <= 0 && w2.EnemiesAlive2 <= 0 && w2.EnemiesAlive3 <= 0 && w2.EnemiesAlive4 <= 0 && w2.BossAlive <= 0 && w2.BossAlive2 <= 0 && w2.BossAlive3 <= 0 && w2.BossAlive4 <= 0)
        {
            WinWin.SetActive(true);
            w2.enabled = false;
            LevelManager.score6 = Score;


        }
    }
   
}
