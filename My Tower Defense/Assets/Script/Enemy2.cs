using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Enemy2 : MonoBehaviour
{
    public float speed = 10f;
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
        target = WayPoints2.points[0];
        
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
        WaveStats();
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
        if (wavepointIndex >= WayPoints2.points.Length - 1)
        {
            WaveSpawner w = GameObject.FindObjectOfType<WaveSpawner>();
            WaveSpawner1 w1 = GameObject.FindObjectOfType<WaveSpawner1>();
            WaveSpawner2 w2 = GameObject.FindObjectOfType<WaveSpawner2>();
            w.EnemiesAlive2--;
            w1.EnemiesAlive2--;
            w2.EnemiesAlive2--;
            p.Lives--;
            Destroy(gameObject);
            return;
        }


        wavepointIndex++;
        target = WayPoints2.points[wavepointIndex];
    }
    void Die()
    {
        WaveSpawner w = GameObject.FindObjectOfType<WaveSpawner>();
        WaveSpawner1 w1 = GameObject.FindObjectOfType<WaveSpawner1>();
        WaveSpawner2 w2 = GameObject.FindObjectOfType<WaveSpawner2>();
        w.EnemiesAlive2--;
        w1.EnemiesAlive2--;
        w2.EnemiesAlive2--;
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
            StartHealth = wave.HealthZombieB1;
            speed = wave.SpeedZombieB1;
        }
        else if (wave1.Wavenumber == 1)
        {
            StartHealth = wave1.HealthZombieB1;
            speed = wave1.SpeedZombieB1;
        }
        else if (wave2.Wavenumber == 1)
        {
            StartHealth = wave2.HealthZombieB1;
            speed = wave2.SpeedZombieB1;
        }
        if (wave.Wavenumber == 2)
        {
            StartHealth = wave.HealthZombieB2;
            speed = wave.SpeedZombieB2;

        }
        else if (wave1.Wavenumber == 2)
        {
            StartHealth = wave1.HealthZombieB2;
            speed = wave1.SpeedZombieB2;
        }
        else if (wave2.Wavenumber == 2)
        {
            StartHealth = wave2.HealthZombieB2;
            speed = wave2.SpeedZombieB2;
        }
        if (wave.Wavenumber == 3)
        {
            StartHealth = wave.HealthZombieB3;
            speed = wave.SpeedZombieB3;
            worth = wave.ZombieWorthB3;

        }
        else if (wave1.Wavenumber == 3)
        {
            StartHealth = wave1.HealthZombieB3;
            speed = wave1.SpeedZombieB3;
            worth = wave1.ZombieWorthB3;
        }
        else if (wave2.Wavenumber == 3)
        {
            StartHealth = wave2.HealthZombieB3;
            speed = wave2.SpeedZombieB3;
            worth = wave2.ZombieWorthB3;
        }
        if (wave.Wavenumber == 4)
        {
            StartHealth = wave.HealthZombieB4;
            speed = wave.SpeedZombieB4;
            worth = wave.ZombieWorthB4;

        }
        else if (wave1.Wavenumber == 4)
        {
            StartHealth = wave1.HealthZombieB4;
            speed = wave1.SpeedZombieB4;
            worth = wave1.ZombieWorthB4;
        }
        else if (wave2.Wavenumber == 4)
        {
            StartHealth = wave2.HealthZombieB4;
            speed = wave2.SpeedZombieB4;
            worth = wave2.ZombieWorthB4;
        }
        if (wave.Wavenumber == 5)
        {
            StartHealth = wave.HealthZombieB5;
            speed = wave.SpeedZombieB5;
            worth = wave.ZombieWorthB5;

        }
        else if (wave1.Wavenumber == 5)
        {
            StartHealth = wave1.HealthZombieB5;
            speed = wave1.SpeedZombieB5;
            worth = wave1.ZombieWorthB5;
        }
        else if (wave2.Wavenumber == 5)
        {
            StartHealth = wave2.HealthZombieB5;
            speed = wave2.SpeedZombieB5;
            worth = wave2.ZombieWorthB5;
        }
        if (wave.Wavenumber == 6)
        {
            StartHealth = wave.HealthZombieB6;
            speed = wave.SpeedZombieB6;
            worth = wave.ZombieWorthB6;

        }
        else if (wave1.Wavenumber == 6)
        {
            StartHealth = wave1.HealthZombieB6;
            speed = wave1.SpeedZombieB6;
            worth = wave1.ZombieWorthB6;
        }
        else if (wave2.Wavenumber == 6)
        {
            StartHealth = wave1.HealthZombieB6;
            speed = wave2.SpeedZombieB6;
            worth = wave2.ZombieWorthB6;
        }
    }
}
