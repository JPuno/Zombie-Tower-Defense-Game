using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldier : MonoBehaviour
{
    private Transform target;
    [Header("Attributes")]
    public float range;
    public float fireRate;
    public float fireCountdown=0f;
    public int Damage;
    public float Speed;
    [Header("Checker")]
    public bool CheckerUp1=false;
    public bool CheckerUp2=false;
    public bool CheckerUp3=false;
    public bool CheckerUp4=false;
    public bool CheckerUp5=false;
    public string enemyTag = "Enemy";
    private float targetrot;
    private Animator enableshoot;
   

    public GameObject bulletPrefab;
    public Transform firepoint;
    private void Start()
    {
        InvokeRepeating("updateTarget", 0f, 0.5f);
        
        
    }
    private void Awake()
    {
        
        enableshoot = GetComponent<Animator>();
    }

    void updateTarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;

        foreach(GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if (distanceToEnemy<shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;

            }
        }
        if (nearestEnemy !=null && shortestDistance<= range)
        {
            target = nearestEnemy.transform;
            
        }
        else
        {
            target = null;
            enableshoot.enabled = false;
            
        }
    }
    private void Update()
    {
       
        if (target == null)
            return;

        Vector3 dir = target.position - transform.position;
        if (dir.magnitude > .05f)
        {
            
            targetrot = Mathf.Atan2(dir.normalized.y, dir.normalized.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, targetrot));
        }
        if (fireCountdown <= 0f)
        {
            Shoot();
            fireCountdown = 1f / fireRate;
        }
        fireCountdown -= Time.deltaTime;
    }
    void Shoot()
    {
        GameObject bulletGo= (GameObject)Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
        Bullet bullet = bulletGo.GetComponent<Bullet>();
       
        if (bullet != null)
        {
            bullet.Seek(target);
            enableshoot.enabled = true;
            
        }
        

    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, range);
    }

}
