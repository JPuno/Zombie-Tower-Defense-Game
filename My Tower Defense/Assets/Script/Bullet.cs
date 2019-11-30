using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    private Transform target;
    public float speed ;
    public int BulletDamage;
    private float targetrot;
    public AudioSource source;
    private void Awake()
    {
        source.enabled = true;
        
    }
    public void Seek(Transform _target)
    {
        target = _target;
    }
    void Update()
    {
        Soldier S = GameObject.FindObjectOfType<Soldier>();
        BulletDamage = S.Damage;
        speed = S.Speed;
        if (target == null)
        {
           
            Destroy(gameObject);
            return;
        }
        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;
        if (dir.magnitude < distanceThisFrame)
        {

            Damage(target);
            Damage2(target);
            Damage3(target);
            Damage4(target);
            DamageBoss1(target);
            DamageBoss2(target);
            DamageBoss3(target);
            DamageBoss4(target);
            Destroy(gameObject);
            return;
            
        }
        transform.Translate(dir.normalized * distanceThisFrame, Space.World);
        targetrot = Mathf.Atan2(dir.normalized.y, dir.normalized.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, targetrot));
    }
    void Damage(Transform enemy)
    {
        Enemy e = enemy.GetComponent<Enemy>();
        
        if (e != null)
        {
            e.TakeDamage(BulletDamage);
           
        }
    }
    void Damage2(Transform enemy2)
    {
        Enemy2 e = enemy2.GetComponent<Enemy2>();

        if (e != null)
        {
            e.TakeDamage(BulletDamage);

        }
    }
    void Damage3(Transform enemy3)
    {
        Enemy3 e = enemy3.GetComponent<Enemy3>();

        if (e != null)
        {
            e.TakeDamage(BulletDamage);

        }
    }
    void Damage4(Transform enemy3)
    {
        Enemy4 e = enemy3.GetComponent<Enemy4>();

        if (e != null)
        {
            e.TakeDamage(BulletDamage);

        }
    }
    void DamageBoss1(Transform boss1)
    {
        EnemyBoss eb = boss1.GetComponent<EnemyBoss>();
        if (eb != null)
        {
            eb.TakeDamage(BulletDamage);

        }
    }
    void DamageBoss2(Transform boss2)
    {
        EnemyBoss2 eb2 = boss2.GetComponent<EnemyBoss2>();
        if (eb2 != null)
        {
            eb2.TakeDamage(BulletDamage);

        }
    }
    void DamageBoss3(Transform boss3)
    {
        EnemyBoss3 eb3 = boss3.GetComponent<EnemyBoss3>();
        if (eb3 != null)
        {
            eb3.TakeDamage(BulletDamage);

        }
    }
    void DamageBoss4(Transform boss3)
    {
        EnemyBoss4 eb4 = boss3.GetComponent<EnemyBoss4>();
        if (eb4 != null)
        {
            eb4.TakeDamage(BulletDamage);

        }
    }
}
