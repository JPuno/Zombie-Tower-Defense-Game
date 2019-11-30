using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Enemy3 : MonoBehaviour
{
    public float speed;
    public float StartHealth;
    public int worth;
    public int worthScore;

    public Image healthBar;
    private AudioSource source;
    private Transform target;
    private int wavepointIndex = 0;
    private float targetrot;
    private float health;
    private bool isDead = false;
    private void Awake()
    {
        WaveStats();
        health = StartHealth;
    }
    private void Start()
    {
        target = WayPoints3.points[0];

        source = GameObject.FindGameObjectWithTag("ZM").GetComponent<AudioSource>();
        source.mute = false;
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        healthBar.fillAmount = health / StartHealth;
        if (health <= 0 && !isDead)
        {
            Die();
        }
    }
    private void Update()
    {

        Vector3 dir = target.position - transform.position;
        if (dir.magnitude > .05f)
        {
            transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
            targetrot = Mathf.Atan2(dir.normalized.y, dir.normalized.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, targetrot));
        }

        if (Vector3.Distance(transform.position, target.position) <= 0.4f)
        {
            GetNextWayPoint();
        }
    }

    private void GetNextWayPoint()
    {
        PlayerStats p = GameObject.FindObjectOfType<PlayerStats>();
        if (wavepointIndex >= WayPoints3.points.Length - 1)
        {
            WaveSpawner1 w = GameObject.FindObjectOfType<WaveSpawner1>();
            WaveSpawner2 w2 = GameObject.FindObjectOfType<WaveSpawner2>();
            w.EnemiesAlive3--;
            w2.EnemiesAlive3--;
            p.Lives--;
            Destroy(gameObject);
            return;
        }


        wavepointIndex++;
        target = WayPoints3.points[wavepointIndex];
    }
    void Die()
    {
        WaveSpawner1 w = GameObject.FindObjectOfType<WaveSpawner1>();
        WaveSpawner2 w2 = GameObject.FindObjectOfType<WaveSpawner2>();
        w.EnemiesAlive3--;
        w2.EnemiesAlive3--;
        GameManager GM = GameObject.FindObjectOfType<GameManager>();
        GM.Gold += worth;
        GM.Score += worthScore;
        isDead = true;
        Destroy(gameObject);
    }
    void WaveStats()
    {
        WaveSpawner1 wave = GameObject.FindObjectOfType<WaveSpawner1>();
        WaveSpawner2 wave2 = GameObject.FindObjectOfType<WaveSpawner2>();
        if (wave.Wavenumber == 1  )
        {
            StartHealth = wave.HealthZombieC1;
            speed = wave.SpeedZombieC1;
            
        }
        else if (wave2.Wavenumber == 1)
        {
            StartHealth = wave2.HealthZombieC1;
            speed = wave2.SpeedZombieC1;
        }

        if (wave.Wavenumber == 2 )
        {
            StartHealth = wave.HealthZombieC2;
            speed = wave.SpeedZombieC2;
            
            
        }
        else if (wave2.Wavenumber == 2)
        {
            StartHealth = wave2.HealthZombieC2;
            speed = wave2.SpeedZombieC2;
        }
        if (wave.Wavenumber == 3 )
        {
            StartHealth = wave.HealthZombieC3;
            speed = wave.SpeedZombieC3;
            worth = wave.ZombieWorthC3;
            
        }
        else if (wave2.Wavenumber == 3)
        {
            StartHealth = wave2.HealthZombieC3;
            speed = wave2.SpeedZombieC3;
            worth = wave2.ZombieWorthC3;
        }
        if (wave.Wavenumber == 4 )
        {
            StartHealth = wave.HealthZombieC4;
            speed = wave.SpeedZombieC4;
            worth = wave.ZombieWorthC4;
            
        }
        else if (wave2.Wavenumber == 4)
        {
            StartHealth = wave2.HealthZombieC4;
            speed = wave2.SpeedZombieC4;
            worth = wave2.ZombieWorthC4;
        }
        if (wave.Wavenumber == 5)
        {
            StartHealth = wave.HealthZombieC5;
            speed = wave.SpeedZombieC5;
            worth = wave.ZombieWorthC5;
            
        }
        else if (wave2.Wavenumber == 5)
        {
            StartHealth = wave2.HealthZombieC5;
            speed = wave2.SpeedZombieC5;
            worth = wave2.ZombieWorthC5;
        }
        if (wave.Wavenumber == 6 )
        {
            StartHealth = wave.HealthZombieC6;
            speed = wave.SpeedZombieC6;
            worth = wave.ZombieWorthC6;
            
        }
        else if (wave2.Wavenumber == 6)
        {
            StartHealth = wave2.HealthZombieC6;
            speed = wave2.SpeedZombieC6;
            worth = wave2.ZombieWorthC6;
        }
    }
}
