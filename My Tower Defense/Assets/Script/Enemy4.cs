using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Enemy4 : MonoBehaviour
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
        target = WayPoints4.points[0];

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
        if (wavepointIndex >= WayPoints4.points.Length - 1)
        {
            WaveSpawner2 w = GameObject.FindObjectOfType<WaveSpawner2>();
            w.EnemiesAlive4--;
            p.Lives--;
            Destroy(gameObject);
            return;
        }


        wavepointIndex++;
        target = WayPoints4.points[wavepointIndex];
    }
    void Die()
    {
        WaveSpawner2 w = GameObject.FindObjectOfType<WaveSpawner2>();
        w.EnemiesAlive4--;
        GameManager GM = GameObject.FindObjectOfType<GameManager>();
        GM.Gold += worth;
        GM.Score += worthScore;
        isDead = true;
        Destroy(gameObject);
    }
    void WaveStats()
    {
        WaveSpawner2 wave = GameObject.FindObjectOfType<WaveSpawner2>();
        if (wave.Wavenumber == 1)
        {
            StartHealth = wave.HealthZombieD1;
            speed = wave.SpeedZombieD1;


        }
        if (wave.Wavenumber == 2)
        {
            StartHealth = wave.HealthZombieD2;
            speed = wave.SpeedZombieD2;


        }
        if (wave.Wavenumber == 3)
        {
            StartHealth = wave.HealthZombieD3;
            speed = wave.SpeedZombieD3;
            worth = wave.ZombieWorthD3;
        }
        if (wave.Wavenumber == 4)
        {
            StartHealth = wave.HealthZombieD4;
            speed = wave.SpeedZombieD4;
            worth = wave.ZombieWorthD4;
        }
        if (wave.Wavenumber == 5)
        {
            StartHealth = wave.HealthZombieD5;
            speed = wave.SpeedZombieD5;
            worth = wave.ZombieWorthD5;
        }
        if (wave.Wavenumber == 6)
        {
            StartHealth = wave.HealthZombieD6;
            speed = wave.SpeedZombieD6;
            worth = wave.ZombieWorthD6;
        }
    }
}
