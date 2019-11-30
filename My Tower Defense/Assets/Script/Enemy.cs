using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Enemy : MonoBehaviour
{
    public float speed;
    public float StartHealth;
    public int worth;
    public int worthScore;

    public Image healthBar;
    private AudioSource source;
    private Transform target;
    private int wavepointIndex=0;
    private float targetrot;
    private float health;
    private bool isDead=false;
    private void Awake()
    {
        WaveStats();
        health = StartHealth;
    }
    private void Start()
    {
        target = Waypoints.points[0];
        
        source = GameObject.FindGameObjectWithTag("ZM").GetComponent<AudioSource>();
        source.mute=false;
    }
   
    public void TakeDamage(float amount)
    {
        health -= amount;
        WaveSpawner wave = GameObject.FindObjectOfType<WaveSpawner>();
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
        if (wavepointIndex >= Waypoints.points.Length - 1)
        {
            WaveSpawner w = GameObject.FindObjectOfType<WaveSpawner>();
            WaveSpawner1 w1 = GameObject.FindObjectOfType<WaveSpawner1>();
            WaveSpawner2 w2 = GameObject.FindObjectOfType<WaveSpawner2>();
            w.EnemiesAlive1--;
            w1.EnemiesAlive1--;
            w2.EnemiesAlive1--;
            p.Lives--;
            Destroy(gameObject);
            return;
        }
       
        
        wavepointIndex++;
        target = Waypoints.points[wavepointIndex];
    }
    void Die()
    {
        WaveSpawner w = GameObject.FindObjectOfType<WaveSpawner>();
        WaveSpawner1 w1 = GameObject.FindObjectOfType<WaveSpawner1>();
        WaveSpawner2 w2 = GameObject.FindObjectOfType<WaveSpawner2>();
        w.EnemiesAlive1--;
        w1.EnemiesAlive1--;
        w2.EnemiesAlive1--;
        GameManager GM = GameObject.FindObjectOfType<GameManager>();
        GM.Gold += worth;
        GM.Score += worthScore;
        isDead = true;
        Destroy(gameObject);
    }
    void WaveStats()
    {
        WaveSpawner wave = GameObject.FindObjectOfType<WaveSpawner>();
        WaveSpawner1 wave1 = GameObject.FindObjectOfType<WaveSpawner1>();
        WaveSpawner2 wave2 = GameObject.FindObjectOfType<WaveSpawner2>();
        if (wave.Wavenumber == 1)
        {
           StartHealth = wave.HealthZombieA1;
            speed = wave.SpeedZombieA1;
        }
        else if(wave1.Wavenumber == 1)
        {
            StartHealth = wave1.HealthZombieA1;
            speed = wave1.SpeedZombieA1;
        }
        else if (wave2.Wavenumber == 1)
        {
            StartHealth = wave2.HealthZombieA1;
            speed = wave2.SpeedZombieA1;
        }
        if (wave.Wavenumber == 2 )
        {
            StartHealth = wave.HealthZombieA2;
            speed = wave.SpeedZombieA2;
           
        }
        else if (wave1.Wavenumber == 2)
        {
            StartHealth = wave1.HealthZombieA2;
            speed = wave1.SpeedZombieA2;
        }
        else if(wave2.Wavenumber == 2)
        {
            StartHealth = wave2.HealthZombieA2;
            speed = wave2.SpeedZombieA2;
        }
        if (wave.Wavenumber == 3 )
        {
            StartHealth = wave.HealthZombieA3;
            speed = wave.SpeedZombieA3;
            worth = wave.ZombieWorthA3;
            
        }
        else if (wave1.Wavenumber == 3)
        {
            StartHealth = wave1.HealthZombieA3;
            speed = wave1.SpeedZombieA3;
            worth = wave1.ZombieWorthA3;
        }
        else if (wave2.Wavenumber == 3)
        {
            StartHealth = wave2.HealthZombieA3;
            speed = wave2.SpeedZombieA3;
            worth = wave2.ZombieWorthA3;
        }
        if (wave.Wavenumber == 4 )
        {
            StartHealth = wave.HealthZombieA4;
            speed = wave.SpeedZombieA4;
            worth = wave.ZombieWorthA4;
            
        }
        else if (wave1.Wavenumber == 4)
        {
            StartHealth = wave1.HealthZombieA4;
            speed = wave1.SpeedZombieA4;
            worth = wave1.ZombieWorthA4;
        }
        else if (wave2.Wavenumber == 4)
        {
            StartHealth = wave2.HealthZombieA4;
            speed = wave2.SpeedZombieA4;
            worth = wave2.ZombieWorthA4;
        }
        if (wave.Wavenumber == 5 )
        {
            StartHealth = wave.HealthZombieA5;
            speed = wave.SpeedZombieA5;
            worth = wave.ZombieWorthA5;
           
        }
        else if (wave1.Wavenumber == 5)
        {
            StartHealth = wave1.HealthZombieA5;
            speed = wave1.SpeedZombieA5;
            worth = wave1.ZombieWorthA5;
        }
        else if (wave2.Wavenumber == 5)
        {
            StartHealth = wave2.HealthZombieA5;
            speed = wave2.SpeedZombieA5;
            worth = wave2.ZombieWorthA5;
        }
        if (wave.Wavenumber == 6 )
        {
            StartHealth = wave.HealthZombieA6;
            speed = wave.SpeedZombieA6;
            worth = wave.ZombieWorthA6;
            
        }
        else if (wave1.Wavenumber == 6)
        {
            StartHealth = wave1.HealthZombieA6;
            speed = wave1.SpeedZombieA6;
            worth = wave1.ZombieWorthA6;
        }
        else if (wave2.Wavenumber == 6)
        {
            StartHealth = wave2.HealthZombieA6;
            speed = wave2.SpeedZombieA6;
            worth = wave2.ZombieWorthA6;
        }
    }
}
