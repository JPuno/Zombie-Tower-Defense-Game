using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveSpawner1 : MonoBehaviour
{
    
    [Header("SpawnEnemyTime")]
    public float timeBetweenWaves;
    public float countdown;
    public float nextWavecountdown;
    [Header("WaveSpawner1")]
    public int SpawnEnemy1NumberWave1;
    public int SpawnEnemy2NumberWave1;
    public int SpawnEnemy3NumberWave1;
    public float spacebetweenZombieA1;
    public float spacebetweenZombieB1;
    public float spacebetweenZombieC1;
    public float SpeedZombieA1;
    public float SpeedZombieB1;
    public float SpeedZombieC1;
    public float HealthZombieA1;
    public float HealthZombieB1;
    public float HealthZombieC1;

    [Header("WaveSpawner2")]
    public int SpawnEnemy1NumberWave2;
    public int SpawnEnemy2NumberWave2;
    public int SpawnEnemy3NumberWave2;
    public int IfPathAisGreaterZombie1Wave2;
    public int IfPathAisGreaterZombie2Wave2;
    public int IfPathAisGreaterZombie3Wave2;
    public int IfPathBisGreaterZombie1Wave2;
    public int IfPathBisGreaterZombie2Wave2;
    public int IfPathBisGreaterZombie3Wave2;
    public int IfPathCisGreaterZombie1Wave2;
    public int IfPathCisGreaterZombie2Wave2;
    public int IfPathCisGreaterZombie3Wave2;
    public float spacebetweenZombieA2;
    public float spacebetweenZombieB2;
    public float spacebetweenZombieC2;
    public float SpeedZombieA2;
    public float SpeedZombieB2;
    public float SpeedZombieC2;
    public float HealthZombieA2;
    public float HealthZombieB2;
    public float HealthZombieC2;
    [Header("WaveSpawner3")]
    public int SpawnEnemy1NumberWave3;
    public int SpawnEnemy2NumberWave3;
    public int SpawnEnemy3NumberWave3;
    public int SpawnBoss1NumberWave3;
    public int SpawnBoss2NumberWave3;
    public int SpawnBoss3NumberWave3;
    public int IfPathAisGreaterZombie1Wave3;
    public int IfPathAisGreaterZombie2Wave3;
    public int IfPathAisGreaterZombie3Wave3;
    public int IfPathBisGreaterZombie1Wave3;
    public int IfPathBisGreaterZombie2Wave3;
    public int IfPathBisGreaterZombie3Wave3;
    public int IfPathCisGreaterZombie1Wave3;
    public int IfPathCisGreaterZombie2Wave3;
    public int IfPathCisGreaterZombie3Wave3;
    public int IfPathAisGreaterBoss1Wave3;
    public int IfPathAisGreaterBoss2Wave3;
    public int IfPathAisGreaterBoss3Wave3;
    public int IfPathBisGreaterBoss1Wave3;
    public int IfPathBisGreaterBoss2Wave3;
    public int IfPathBisGreaterBoss3Wave3;
    public int IfPathCisGreaterBoss1Wave3;
    public int IfPathCisGreaterBoss2Wave3;
    public int IfPathCisGreaterBoss3Wave3;
    public float spacebetweenZombieA3;
    public float spacebetweenZombieB3;
    public float spacebetweenZombieC3;
    public float spacebetweenBossA3;
    public float spacebetweenBossB3;
    public float spacebetweenBossC3;
    public float SpeedZombieA3;
    public float SpeedZombieB3;
    public float SpeedZombieC3;
    public float SpeedBossA3;
    public float SpeedBossB3;
    public float SpeedBossC3;
    public float HealthZombieA3;
    public float HealthZombieB3;
    public float HealthZombieC3;
    public float HealthBossA3;
    public float HealthBossB3;
    public float HealthBossC3;
    public int ZombieWorthA3;
    public int ZombieWorthB3;
    public int ZombieWorthC3;
    [Header("WaveSpawner4")]
    public int SpawnEnemy1NumberWave4;
    public int SpawnEnemy2NumberWave4;
    public int SpawnEnemy3NumberWave4;
    public int IfPathAisGreaterZombie1Wave4;
    public int IfPathAisGreaterZombie2Wave4;
    public int IfPathAisGreaterZombie3Wave4;
    public int IfPathBisGreaterZombie1Wave4;
    public int IfPathBisGreaterZombie2Wave4;
    public int IfPathBisGreaterZombie3Wave4;
    public int IfPathCisGreaterZombie1Wave4;
    public int IfPathCisGreaterZombie2Wave4;
    public int IfPathCisGreaterZombie3Wave4;
    public float spacebetweenZombieA4;
    public float spacebetweenZombieB4;
    public float spacebetweenZombieC4;
    public float SpeedZombieA4;
    public float SpeedZombieB4;
    public float SpeedZombieC4;
    public float HealthZombieA4;
    public float HealthZombieB4;
    public float HealthZombieC4;
    public int ZombieWorthA4;
    public int ZombieWorthB4;
    public int ZombieWorthC4;
    [Header("WaveSpawner5")]
    public int SpawnEnemy1NumberWave5;
    public int SpawnEnemy2NumberWave5;
    public int SpawnEnemy3NumberWave5;
    public int IfPathAisGreaterZombie1Wave5;
    public int IfPathAisGreaterZombie2Wave5;
    public int IfPathAisGreaterZombie3Wave5;
    public int IfPathBisGreaterZombie1Wave5;
    public int IfPathBisGreaterZombie2Wave5;
    public int IfPathBisGreaterZombie3Wave5;
    public int IfPathCisGreaterZombie1Wave5;
    public int IfPathCisGreaterZombie2Wave5;
    public int IfPathCisGreaterZombie3Wave5;
    public float spacebetweenZombieA5;
    public float spacebetweenZombieB5;
    public float spacebetweenZombieC5;
    public float SpeedZombieA5;
    public float SpeedZombieB5;
    public float SpeedZombieC5;
    public float HealthZombieA5;
    public float HealthZombieB5;
    public float HealthZombieC5;
    public int ZombieWorthA5;
    public int ZombieWorthB5;
    public int ZombieWorthC5;
    [Header("WaveSpawner6")]
    public int SpawnEnemy1NumberWave6;
    public int SpawnEnemy2NumberWave6;
    public int SpawnEnemy3NumberWave6;
    public int SpawnBoss1NumberWave6;
    public int SpawnBoss2NumberWave6;
    public int SpawnBoss3NumberWave6;
    public int IfPathAisGreaterZombie1Wave6;
    public int IfPathAisGreaterZombie2Wave6;
    public int IfPathAisGreaterZombie3Wave6;
    public int IfPathBisGreaterZombie1Wave6;
    public int IfPathBisGreaterZombie2Wave6;
    public int IfPathBisGreaterZombie3Wave6;
    public int IfPathCisGreaterZombie1Wave6;
    public int IfPathCisGreaterZombie2Wave6;
    public int IfPathCisGreaterZombie3Wave6;
    public int IfPathAisGreaterBoss1Wave6;
    public int IfPathAisGreaterBoss2Wave6;
    public int IfPathAisGreaterBoss3Wave6;
    public int IfPathBisGreaterBoss1Wave6;
    public int IfPathBisGreaterBoss2Wave6;
    public int IfPathBisGreaterBoss3Wave6;
    public int IfPathCisGreaterBoss1Wave6;
    public int IfPathCisGreaterBoss2Wave6;
    public int IfPathCisGreaterBoss3Wave6;
    public float spacebetweenZombieA6;
    public float spacebetweenZombieB6;
    public float spacebetweenZombieC6;
    public float spacebetweenBossA6;
    public float spacebetweenBossB6;
    public float spacebetweenBossC6;
    public float SpeedZombieA6;
    public float SpeedZombieB6;
    public float SpeedZombieC6;
    public float SpeedBossA6;
    public float SpeedBossB6;
    public float SpeedBossC6;
    public float HealthZombieA6;
    public float HealthZombieB6;
    public float HealthZombieC6;
    public float HealthBossA6;
    public float HealthBossB6;
    public float HealthBossC6;
    public int ZombieWorthA6;
    public int ZombieWorthB6;
    public int ZombieWorthC6;
    [Header("Data Needed by another Script")]
    public int EnemiesAlive1;
    public int EnemiesAlive2;
    public int EnemiesAlive3;
    public int BossAlive;
    public int BossAlive2;
    public int BossAlive3;
    public Transform SpawnPoint;
    public Transform SpawnPoint2;
    public Transform SpawnPoint3;
    public GameObject enemyPrefab;
    public GameObject enemyPrefab2;
    public GameObject enemyPrefab3;
    public GameObject BossPrefab;
    public GameObject BossPrefab2;
    public GameObject BossPrefab3;
    public int waveNumber1;
    public int waveNumber2;
    public int waveNumber3;
    public int bosswave;
    public int bosswave2;
    public int bosswave3;
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
                StartCoroutine(Spawnwave3());
                if (countdown<=0&&Wavenumber == 3)
                {
                    StartCoroutine(BossSpawnwave());
                    StartCoroutine(BossSpawnwave2());
                    StartCoroutine(BossSpawnwave3());
                }
                else if (countdown <= 0 && Wavenumber == 6)
                {
                    StartCoroutine(BossSpawnwave());
                    StartCoroutine(BossSpawnwave2());
                    StartCoroutine(BossSpawnwave3());
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
        else if(spawnNow==true&&EnemiesAlive1 == 0&& EnemiesAlive2 == 0 && EnemiesAlive3 == 0 && BossAlive ==0 && BossAlive2 ==0 && BossAlive3==0)
        {
            spawnNow = false;
            Source.mute = true;
            if (Wavenumber ==1 || Wavenumber == 2 || Wavenumber == 3 || Wavenumber == 4 || Wavenumber == 5)
            {
                GameManager GM = GameObject.FindObjectOfType<GameManager>();
                GM.Gold += Reward;
                EnemiesAlive1 = 1;
                EnemiesAlive2 = 1;
                EnemiesAlive3 = 1;
                BTNWave.SetActive(true);
                Guard.SetActive(true);
            }
          
        }
        else if (Wavenumber == 6 && EnemiesAlive1 == 0 && EnemiesAlive2 == 0 && EnemiesAlive3 == 0 && BossAlive == 0 && BossAlive2 == 0 && BossAlive3 == 0)
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
    IEnumerator Spawnwave3()
    {
        EnemiesAlive3 = waveNumber3;
        for (int i = 0; i < waveNumber3; i++)
        {
            SpawnEnemy3();
            yield return new WaitForSeconds(spacebetweenZombieC1);
        }
        waveNumber3++;

    }
    IEnumerator BossSpawnwave3()
    {
        BossAlive3 = bosswave3;
        for (int i = 0; i < bosswave3; i++)
        {
            BossSpawn3();
            yield return new WaitForSeconds(spacebetweenBossC3);
        }
        bosswave3++;


    }
    void SpawnEnemy()
    {
        
      GameObject enemy1=(GameObject)Instantiate(enemyPrefab, SpawnPoint.position, SpawnPoint.rotation);
        
    }
    void SpawnEnemy2()
    {
        GameObject enemy2 = (GameObject)Instantiate(enemyPrefab2, SpawnPoint2.position, SpawnPoint2.rotation);
    }
    void SpawnEnemy3()
    {
        GameObject enemy3 = (GameObject)Instantiate(enemyPrefab3, SpawnPoint3.position, SpawnPoint3.rotation);
    }
    void BossSpawn()
    {
        GameObject boss1 = (GameObject)Instantiate(BossPrefab, SpawnPoint.position, SpawnPoint.rotation);
    }
    void BossSpawn2()
    {
        GameObject boss2 = (GameObject)Instantiate(BossPrefab2, SpawnPoint2.position, SpawnPoint2.rotation);
    }
    void BossSpawn3()
    {
        GameObject boss3 = (GameObject)Instantiate(BossPrefab3, SpawnPoint3.position, SpawnPoint3.rotation);
    }
    public void BTNWAVE()
    {
        Evaluate e1 = GameObject.FindObjectOfType<Evaluate>();
        Evaluate1 e2 = GameObject.FindObjectOfType<Evaluate1>();
        Evaluate2 e3 = GameObject.FindObjectOfType<Evaluate2>();
        Guard.SetActive(false);

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
            waveNumber3 = SpawnEnemy3NumberWave1;
            
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
            spacebetweenZombieC1 = spacebetweenZombieC2;
            if (e1.evaluatePathA>e2.evaluatePathB && e1.evaluatePathA > e3.evaluatePathC)
            {
                waveNumber1 = IfPathAisGreaterZombie1Wave2;
                waveNumber2 = IfPathAisGreaterZombie2Wave2;
                waveNumber3 = IfPathAisGreaterZombie3Wave2;


            }
            else if (e2.evaluatePathB>e1.evaluatePathA && e2.evaluatePathB > e3.evaluatePathC)
            {
                waveNumber1 = IfPathBisGreaterZombie1Wave2;
                waveNumber2 = IfPathBisGreaterZombie2Wave2;
                waveNumber3 = IfPathBisGreaterZombie3Wave2;


            }
            else if (e2.evaluatePathB < e3.evaluatePathC && e1.evaluatePathA < e3.evaluatePathC)
            {
                waveNumber1 = IfPathCisGreaterZombie1Wave2;
                waveNumber2 = IfPathCisGreaterZombie2Wave2;
                waveNumber3 = IfPathCisGreaterZombie3Wave2;


            }
            else 
            {
                waveNumber1 =SpawnEnemy1NumberWave2;
                waveNumber2 =SpawnEnemy2NumberWave2;
                waveNumber3 = SpawnEnemy3NumberWave2;


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
            spacebetweenZombieC1 = spacebetweenZombieC3;
            if (e1.evaluatePathA > e2.evaluatePathB && e1.evaluatePathA > e3.evaluatePathC)
            {
                waveNumber1 = IfPathAisGreaterZombie1Wave3;
                waveNumber2 = IfPathAisGreaterZombie2Wave3;
                waveNumber3 = IfPathAisGreaterZombie3Wave3;
                bosswave = IfPathAisGreaterBoss1Wave3;
                bosswave2 = IfPathAisGreaterBoss2Wave3;
                bosswave3 = IfPathAisGreaterBoss3Wave3;

            }
            else if (e2.evaluatePathB > e1.evaluatePathA && e2.evaluatePathB > e3.evaluatePathC)
            {
                waveNumber1 = IfPathBisGreaterZombie1Wave3;
                waveNumber2 = IfPathBisGreaterZombie2Wave3;
                waveNumber3 = IfPathBisGreaterZombie3Wave3;
                bosswave = IfPathBisGreaterBoss1Wave3;
                bosswave2 = IfPathBisGreaterBoss2Wave3;
                bosswave3 = IfPathBisGreaterBoss3Wave3;

            }
            else if (e2.evaluatePathB < e3.evaluatePathC && e1.evaluatePathA < e3.evaluatePathC)
            {
                waveNumber1 = IfPathCisGreaterZombie1Wave3;
                waveNumber2 = IfPathCisGreaterZombie2Wave3;
                waveNumber3 = IfPathCisGreaterZombie3Wave3;
                bosswave = IfPathCisGreaterBoss1Wave3;
                bosswave2 = IfPathCisGreaterBoss2Wave3;
                bosswave3 = IfPathCisGreaterBoss3Wave3;

            }
            else
            {
                waveNumber1 = SpawnEnemy1NumberWave3;
                waveNumber2 = SpawnEnemy2NumberWave3;
                waveNumber3 = SpawnEnemy3NumberWave3;
                bosswave = SpawnBoss1NumberWave3;
                bosswave2 = SpawnBoss2NumberWave3;
                bosswave3 = SpawnBoss3NumberWave3;

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
            spacebetweenZombieC1 = spacebetweenZombieC4;
            if (e1.evaluatePathA > e2.evaluatePathB && e1.evaluatePathA > e3.evaluatePathC)
            {
                waveNumber1 = IfPathAisGreaterZombie1Wave4;
                waveNumber2 = IfPathAisGreaterZombie2Wave4;
                waveNumber3 = IfPathAisGreaterZombie3Wave4;


            }
            else if (e2.evaluatePathB > e1.evaluatePathA && e2.evaluatePathB > e3.evaluatePathC)
            {
                waveNumber1 = IfPathBisGreaterZombie1Wave4;
                waveNumber2 = IfPathBisGreaterZombie2Wave4;
                waveNumber3 = IfPathBisGreaterZombie3Wave4;


            }
            else if (e2.evaluatePathB < e3.evaluatePathC && e1.evaluatePathA < e3.evaluatePathC)
            {
                waveNumber1 = IfPathCisGreaterZombie1Wave4;
                waveNumber2 = IfPathCisGreaterZombie2Wave4;
                waveNumber3 = IfPathCisGreaterZombie3Wave4;


            }
            else 
            {
                waveNumber1 = SpawnEnemy1NumberWave4;
                waveNumber2 = SpawnEnemy2NumberWave4;
                waveNumber3 = SpawnEnemy3NumberWave4;

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
            spacebetweenZombieC1 = spacebetweenZombieC5;
            if (e1.evaluatePathA > e2.evaluatePathB && e1.evaluatePathA > e3.evaluatePathC)
            {
                waveNumber1 = IfPathAisGreaterZombie1Wave5;
                waveNumber2 = IfPathAisGreaterZombie2Wave5;
                waveNumber3 = IfPathAisGreaterZombie3Wave5;

            }
            else if (e2.evaluatePathB > e1.evaluatePathA && e2.evaluatePathB > e3.evaluatePathC)
            {
                waveNumber1 = IfPathBisGreaterZombie1Wave5;
                waveNumber2 = IfPathBisGreaterZombie2Wave5;
                waveNumber3 = IfPathBisGreaterZombie3Wave5;


            }
            else if (e2.evaluatePathB < e3.evaluatePathC && e1.evaluatePathA < e3.evaluatePathC)
            {
                waveNumber1 = IfPathCisGreaterZombie1Wave5;
                waveNumber2 = IfPathCisGreaterZombie2Wave5;
                waveNumber3 = IfPathCisGreaterZombie3Wave5;


            }
            else 
            {
                waveNumber1 =SpawnEnemy1NumberWave5;
                waveNumber2 = SpawnEnemy2NumberWave5;
                waveNumber3 = SpawnEnemy3NumberWave5;

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
            spacebetweenZombieC1 = spacebetweenZombieC6;
            spacebetweenBossA3 = spacebetweenBossA6;
            spacebetweenBossB3 = spacebetweenBossB6;
            spacebetweenBossC3 = spacebetweenBossC6;
            if (e1.evaluatePathA > e2.evaluatePathB && e1.evaluatePathA > e3.evaluatePathC)
            {
                waveNumber1 = IfPathAisGreaterZombie1Wave6;
                waveNumber2 = IfPathAisGreaterZombie2Wave6;
                waveNumber3 = IfPathAisGreaterZombie3Wave6;
                bosswave = IfPathAisGreaterBoss1Wave6;
                bosswave2 = IfPathAisGreaterBoss2Wave6;
                bosswave3 = IfPathAisGreaterBoss3Wave6;
            }
            else if (e2.evaluatePathB > e1.evaluatePathA && e2.evaluatePathB > e3.evaluatePathC)
            {
                waveNumber1 =IfPathBisGreaterZombie1Wave6;
                waveNumber2 = IfPathBisGreaterZombie2Wave6;
                waveNumber2 = IfPathBisGreaterZombie3Wave6;
                bosswave = IfPathBisGreaterBoss1Wave6;
                bosswave2 = IfPathBisGreaterBoss2Wave6;
                bosswave3 = IfPathBisGreaterBoss3Wave6;
            }
            else if (e2.evaluatePathB < e3.evaluatePathC && e1.evaluatePathA < e3.evaluatePathC)
            {
                waveNumber1 = IfPathCisGreaterZombie1Wave6;
                waveNumber2 = IfPathCisGreaterZombie2Wave6;
                waveNumber3 = IfPathCisGreaterZombie3Wave6;
                bosswave = IfPathCisGreaterBoss1Wave6;
                bosswave2 = IfPathCisGreaterBoss2Wave6;
                bosswave3 = IfPathCisGreaterBoss3Wave6;

            }
            else  
            {
                waveNumber1 = SpawnEnemy1NumberWave6;
                waveNumber2 = SpawnEnemy2NumberWave6;
                waveNumber3 = SpawnEnemy3NumberWave6;
                bosswave = SpawnBoss1NumberWave6;
                bosswave2 = SpawnBoss2NumberWave6;
                bosswave3 = SpawnBoss3NumberWave6;
            }
        }
        Wavenumber++;
        
    }
}
