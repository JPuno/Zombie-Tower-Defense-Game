using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyBoss : MonoBehaviour
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
        target = Waypoints.points[0];

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
        if (wavepointIndex >= Waypoints.points.Length - 1)
        {
            WaveSpawner w = GameObject.FindObjectOfType<WaveSpawner>();
            WaveSpawner1 w1 = GameObject.FindObjectOfType<WaveSpawner1>();
            WaveSpawner2 w2 = GameObject.FindObjectOfType<WaveSpawner2>();
            w.BossAlive--;
            w1.BossAlive--;
            w2.BossAlive--;
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
        w.BossAlive--;
        w1.BossAlive--;
        w2.BossAlive--;
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
        if (wave.Wavenumber == 3 )
        {
            StartHealth = wave.HealthBossA3;
            speed = wave.SpeedBossA3;
            
        }
        else if (wave1.Wavenumber == 3)
        {

            StartHealth = wave1.HealthBossA3;
            speed = wave1.SpeedBossA3;
        }
        else if (wave2.Wavenumber == 3)
        {

            StartHealth = wave2.HealthBossA3;
            speed = wave2.SpeedBossA3;
        }
        if (wave.Wavenumber == 6 )
        {
            StartHealth = wave.HealthBossA6;
            speed = wave.SpeedBossA6;
           
        }
        else if (wave1.Wavenumber == 6)
        {

            StartHealth = wave1.HealthBossA6;
            speed = wave1.SpeedBossA6;
        }
        else if (wave2.Wavenumber == 6)
        {
            StartHealth = wave2.HealthBossA6;
            speed = wave2.SpeedBossA6;
        }
    }
}
