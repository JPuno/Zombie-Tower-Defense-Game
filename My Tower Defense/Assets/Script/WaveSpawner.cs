using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{
    
    [Header("SpawnEnemyTime")]
    public float timeBetweenWaves;
    public float countdown;
    public float nextWavecountdown;
    [Header("WaveSpawner1")]
    public int SpawnEnemy1NumberWave1;
    public int SpawnEnemy2NumberWave1;
    public float spacebetweenZombieA1;
    public float spacebetweenZombieB1;
    public float SpeedZombieA1;
    public float SpeedZombieB1;
    public float HealthZombieA1;
    public float HealthZombieB1;

    [Header("WaveSpawner2")]
    public int SpawnEnemy1NumberWave2;
    public int SpawnEnemy2NumberWave2;
    public int IfPathAisGreaterZombie1Wave2;
    public int IfPathAisGreaterZombie2Wave2;
    public int IfPathBisGreaterZombie1Wave2;
    public int IfPathBisGreaterZombie2Wave2;
    public float spacebetweenZombieA2;
    public float spacebetweenZombieB2;
    public float SpeedZombieA2;
    public float SpeedZombieB2;
    public float HealthZombieA2;
    public float HealthZombieB2;
    [Header("WaveSpawner3")]
    public int SpawnEnemy1NumberWave3;
    public int SpawnEnemy2NumberWave3;
    public int SpawnBoss1NumberWave3;
    public int SpawnBoss2NumberWave3;
    public int IfPathAisGreaterZombie1Wave3;
    public int IfPathAisGreaterZombie2Wave3;
    public int IfPathBisGreaterZombie1Wave3;
    public int IfPathBisGreaterZombie2Wave3;
    public int IfPathAisGreaterBoss1Wave3;
    public int IfPathAisGreaterBoss2Wave3;
    public int IfPathBisGreaterBoss1Wave3;
    public int IfPathBisGreaterBoss2Wave3;
    public float spacebetweenZombieA3;
    public float spacebetweenZombieB3;
    public float spacebetweenBossA3;
    public float spacebetweenBossB3;
    public float SpeedZombieA3;
    public float SpeedZombieB3;
    public float SpeedBossA3;
    public float SpeedBossB3;
    public float HealthZombieA3;
    public float HealthZombieB3;
    public float HealthBossA3;
    public float HealthBossB3;
    public int ZombieWorthA3;
    public int ZombieWorthB3;
    [Header("WaveSpawner4")]
    public int SpawnEnemy1NumberWave4;
    public int SpawnEnemy2NumberWave4;
    public int IfPathAisGreaterZombie1Wave4;
    public int IfPathAisGreaterZombie2Wave4;
    public int IfPathBisGreaterZombie1Wave4;
    public int IfPathBisGreaterZombie2Wave4;
    public float spacebetweenZombieA4;
    public float spacebetweenZombieB4;
    public float SpeedZombieA4;
    public float SpeedZombieB4;
    public float HealthZombieA4;
    public float HealthZombieB4;
    public int ZombieWorthA4;
    public int ZombieWorthB4;
    [Header("WaveSpawner5")]
    public int SpawnEnemy1NumberWave5;
    public int SpawnEnemy2NumberWave5;
    public int IfPathAisGreaterZombie1Wave5;
    public int IfPathAisGreaterZombie2Wave5;
    public int IfPathBisGreaterZombie1Wave5;
    public int IfPathBisGreaterZombie2Wave5;
    public float spacebetweenZombieA5;
    public float spacebetweenZombieB5;
    public float SpeedZombieA5;
    public float SpeedZombieB5;
    public float HealthZombieA5;
    public float HealthZombieB5;
    public int ZombieWorthA5;
    public int ZombieWorthB5;
    [Header("WaveSpawner6")]
    public int SpawnEnemy1NumberWave6;
    public int SpawnEnemy2NumberWave6;
    public int SpawnBoss1NumberWave6;
    public int SpawnBoss2NumberWave6;
    public int IfPathAisGreaterZombie1Wave6;
    public int IfPathAisGreaterZombie2Wave6;
    public int IfPathBisGreaterZombie1Wave6;
    public int IfPathBisGreaterZombie2Wave6;
    public int IfPathAisGreaterBoss1Wave6;
    public int IfPathAisGreaterBoss2Wave6;
    public int IfPathBisGreaterBoss1Wave6;
    public int IfPathBisGreaterBoss2Wave6;
    public float spacebetweenZombieA6;
    public float spacebetweenZombieB6;
    public float spacebetweenBossA6;
    public float spacebetweenBossB6;
    public float SpeedZombieA6;
    public float SpeedZombieB6;
    public float SpeedBossA6;
    public float SpeedBossB6;
    public float HealthZombieA6;
    public float HealthZombieB6;
    public float HealthBossA6;
    public float HealthBossB6;
    public int ZombieWorthA6;
    public int ZombieWorthB6;
    [Header("Data Needed by another Script")]
    public int EnemiesAlive1;
    public int EnemiesAlive2;
    public int BossAlive;
    public int BossAlive2;
    public Transform SpawnPoint;
    public Transform SpawnPoint2;
    public GameObject enemyPrefab;
    public GameObject enemyPrefab2;
    public GameObject BossPrefab;
    public GameObject BossPrefab2;
    public int waveNumber1;
    public int waveNumber2;
    public int bosswave;
    public int bosswave2;
    public bool spawnNow=false;
    public int Wavenumber;
    public AudioSource Source;
    public int Reward;
    [Header("UI")]
    public GameObject BTNWave;
    public Text ChangeBTNtxt;
    public Text WaveText;
    public Text waveCountdownText;
    public GameObject Guard;

    private void Update()
    {
        if (spawnNow == true)
        {

            if (countdown <= 0)
            {

                StartCoroutine(Spawnwave());
                StartCoroutine(Spawnwave2());
                if (countdown<=0&&Wavenumber == 3)
                {
                    StartCoroutine(BossSpawnwave());
                    StartCoroutine(BossSpawnwave2());
                }
                else if (countdown <= 0 && Wavenumber == 6)
                {
                    StartCoroutine(BossSpawnwave());
                    StartCoroutine(BossSpawnwave2());
                }
                countdown = timeBetweenWaves;
            }
            

            nextWavecountdown -= Time.deltaTime;
            countdown -= Time.deltaTime;
            countdown = Mathf.Clamp(countdown, 0f, Mathf.Infinity);
            nextWavecountdown = Mathf.Clamp(nextWavecountdown, 0f, Mathf.Infinity);
        }
        if (nextWavecountdown <= 0)
        {
            spawnNow = false;
            BTNWave.SetActive(true);
            Guard.SetActive(true);
           
        }
        else if(spawnNow==true&&EnemiesAlive1 == 0&& EnemiesAlive2 == 0 && BossAlive==0 && BossAlive2 ==0)
        {
            spawnNow = false;
            Source.mute = true;
            if (Wavenumber ==1 || Wavenumber == 2 || Wavenumber == 3 || Wavenumber == 4 || Wavenumber == 5)
            {
                EnemiesAlive1 = 1;
                EnemiesAlive2 = 1;
                GameManager GM = GameObject.FindObjectOfType<GameManager>();
                GM.Gold += Reward;
                BTNWave.SetActive(true);
                Guard.SetActive(true);
            }
          
        }
        else if (Wavenumber == 6 && EnemiesAlive1 == 0 && EnemiesAlive2 == 0 && BossAlive == 0 && BossAlive2 == 0)
        {
          
            spawnNow = false;
            BTNWave.SetActive(false);
            return;
        }
       
        WaveText.text = "Wave:"+ Wavenumber + "/6";
        waveCountdownText.text = "Next Wave:" + string.Format("{0:00.00}", nextWavecountdown);
    }
   IEnumerator Spawnwave()
    {
        EnemiesAlive1 = waveNumber1;
        for (int i = 0; i < waveNumber1; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(spacebetweenZombieA1);
        }
        waveNumber1++;
       
            
    }
    IEnumerator BossSpawnwave()
    {
        BossAlive=bosswave;
        for (int i = 0; i < bosswave; i++)
        {
            BossSpawn();
            yield return new WaitForSeconds(spacebetweenBossA3);
        }
        bosswave++;


    }
    IEnumerator Spawnwave2()
    {
        EnemiesAlive2 = waveNumber2;
        for (int i = 0; i < waveNumber2; i++)
        {
            SpawnEnemy2();
            yield return new WaitForSeconds(spacebetweenZombieB1);
        }
        waveNumber2++;

    }
    IEnumerator BossSpawnwave2()
    {
        BossAlive2 = bosswave2;
        for (int i = 0; i < bosswave2; i++)
        {
            BossSpawn2();
            yield return new WaitForSeconds(spacebetweenBossB3);
        }
        bosswave2++;


    }
    void SpawnEnemy()
    {
        
      GameObject enemy1=(GameObject)Instantiate(enemyPrefab, SpawnPoint.position, SpawnPoint.rotation);
        
    }
    void SpawnEnemy2()
    {
        GameObject enemy2 = (GameObject)Instantiate(enemyPrefab2, SpawnPoint2.position, SpawnPoint2.rotation);
    }
    void BossSpawn()
    {
        GameObject boss1 = (GameObject)Instantiate(BossPrefab, SpawnPoint.position, SpawnPoint.rotation);
    }
    void BossSpawn2()
    {
        GameObject boss2 = (GameObject)Instantiate(BossPrefab2, SpawnPoint2.position, SpawnPoint2.rotation);
    }
    public void BTNWAVE()
    {
        Guard.SetActive(false);
        Evaluate e1 = GameObject.FindObjectOfType<Evaluate>();
        Evaluate1 e2 = GameObject.FindObjectOfType<Evaluate1>();
       
        if (Wavenumber == 0)
        {
            spawnNow = true;
            BTNWave.SetActive(false);
            ChangeBTNtxt.text = "Next Wave";
            countdown = 5f;
            nextWavecountdown = 200f;
            timeBetweenWaves = 200f;
            waveNumber1 = SpawnEnemy1NumberWave1;
            waveNumber2 = SpawnEnemy2NumberWave1;
            
        }
        else if (Wavenumber ==1)
        {
            
            spawnNow = true;
            BTNWave.SetActive(false);
            ChangeBTNtxt.text = "Next Wave";
            countdown = 5f;
            nextWavecountdown = 200f;
            timeBetweenWaves = 200f;
            spacebetweenZombieA1 = spacebetweenZombieA2;
            spacebetweenZombieB1 = spacebetweenZombieB2;
            if (e1.evaluatePathA>e2.evaluatePathB)
            {
                waveNumber1 = IfPathAisGreaterZombie1Wave2;
                waveNumber2 = IfPathAisGreaterZombie2Wave2;
                

            }
            else if (e2.evaluatePathB>e1.evaluatePathA)
            {
                waveNumber1 = IfPathBisGreaterZombie1Wave2;
                waveNumber2 = IfPathBisGreaterZombie2Wave2;
                

            }
            else if(e2.evaluatePathB == e1.evaluatePathA)
            {
                waveNumber1 =SpawnEnemy1NumberWave2;
                waveNumber2 =SpawnEnemy2NumberWave2;
               
            }
        }
        else if (Wavenumber ==2)
        {
            spawnNow = true;
            BTNWave.SetActive(false);
            ChangeBTNtxt.text = "Next Wave";
            countdown = 5f;
            nextWavecountdown = 200f;
            timeBetweenWaves = 200f;
            spacebetweenZombieA1 = spacebetweenZombieA3;
            spacebetweenZombieB1 = spacebetweenZombieB3;
            if (e1.evaluatePathA > e2.evaluatePathB)
            {
                waveNumber1 = IfPathAisGreaterZombie1Wave3;
                waveNumber2 = IfPathAisGreaterZombie2Wave3;
                bosswave = IfPathAisGreaterBoss1Wave3;
                bosswave2 = IfPathAisGreaterBoss2Wave3;

            }
            else if (e2.evaluatePathB > e1.evaluatePathA)
            {
                waveNumber1 = IfPathBisGreaterZombie1Wave3;
                waveNumber2 = IfPathBisGreaterZombie2Wave3;
                bosswave = IfPathBisGreaterBoss1Wave3;
                bosswave2 = IfPathBisGreaterBoss2Wave3;

            }
            else if (e2.evaluatePathB == e1.evaluatePathA)
            {
                waveNumber1 = SpawnEnemy1NumberWave3;
                waveNumber2 = SpawnEnemy2NumberWave3;
                bosswave = SpawnBoss1NumberWave3;
                bosswave2 = SpawnBoss2NumberWave3;

            }
        }
        else if (Wavenumber == 3)
        {
            spawnNow = true;
            BTNWave.SetActive(false);
            ChangeBTNtxt.text = "Next Wave";
            countdown = 5f;
            nextWavecountdown = 200f;
            timeBetweenWaves = 200f;
            spacebetweenZombieA1 = spacebetweenZombieA4;
            spacebetweenZombieB1 = spacebetweenZombieB4;
            if (e1.evaluatePathA > e2.evaluatePathB)
            {
                waveNumber1 = IfPathAisGreaterZombie1Wave4;
                waveNumber2 = IfPathAisGreaterZombie2Wave4;
                

            }
            else if (e2.evaluatePathB > e1.evaluatePathA)
            {
                waveNumber1 = IfPathBisGreaterZombie1Wave4;
                waveNumber2 = IfPathBisGreaterZombie2Wave4;
                

            }
            else if (e2.evaluatePathB == e1.evaluatePathA)
            {
                waveNumber1 = SpawnEnemy1NumberWave4;
                waveNumber2 = SpawnEnemy2NumberWave4;
               
            }
        }
        else if (Wavenumber == 4)
        {
            spawnNow = true;
            BTNWave.SetActive(false);
            ChangeBTNtxt.text = "Final Wave";
            countdown = 5f;
            nextWavecountdown = 200f;
            timeBetweenWaves = 200f;
            spacebetweenZombieA1 = spacebetweenZombieA5;
            spacebetweenZombieB1 = spacebetweenZombieB5;
            if (e1.evaluatePathA > e2.evaluatePathB)
            {
                waveNumber1 = IfPathAisGreaterZombie1Wave5;
                waveNumber2 = IfPathAisGreaterZombie2Wave5;
                

            }
            else if (e2.evaluatePathB > e1.evaluatePathA)
            {
                waveNumber1 = IfPathBisGreaterZombie1Wave5;
                waveNumber2 = IfPathBisGreaterZombie2Wave5;
               


            }
            else if (e2.evaluatePathB == e1.evaluatePathA)
            {
                waveNumber1 =SpawnEnemy1NumberWave5;
                waveNumber2 = SpawnEnemy2NumberWave5;
              
            }
        }
        else if (Wavenumber == 5)
        {
            spawnNow = true;
            BTNWave.SetActive(false);
            countdown = 5f;
            nextWavecountdown = 200f;
            timeBetweenWaves = 200f;
            spacebetweenZombieA1 = spacebetweenZombieA6;
            spacebetweenZombieB1 = spacebetweenZombieB6;
            if (e1.evaluatePathA > e2.evaluatePathB)
            {
                waveNumber1 = IfPathAisGreaterZombie1Wave6;
                waveNumber2 = IfPathAisGreaterZombie2Wave6;
                bosswave = IfPathAisGreaterBoss1Wave6;
                bosswave2 = IfPathAisGreaterBoss2Wave6;

            }
            else if (e2.evaluatePathB > e1.evaluatePathA)
            {
                waveNumber1 =IfPathBisGreaterZombie1Wave6;
                waveNumber2 = IfPathBisGreaterZombie2Wave6;
                bosswave = IfPathBisGreaterBoss1Wave6;
                bosswave2 = IfPathBisGreaterBoss2Wave6;
            }
            else if (e2.evaluatePathB == e1.evaluatePathA)
            {
                waveNumber1 = SpawnEnemy1NumberWave6;
                waveNumber2 = SpawnEnemy2NumberWave6;
                bosswave = SpawnBoss1NumberWave6;
                bosswave2 = SpawnBoss2NumberWave6;
            }
        }
        Wavenumber++;
        
    }
}
