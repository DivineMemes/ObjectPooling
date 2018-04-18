using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    ObjectPool pool;
    public GameObject Bullet;
    public float bulletSpeed;
    public float bulletLifeTime;



    void Start()
    {
        pool = GetComponent<ObjectPool>();
    }
   
    void Spawn()
    {
        GameObject spawnedBullet = pool.getObject();
        spawnedBullet.transform.position = transform.position + transform.forward;
        spawnedBullet.GetComponent<Rigidbody>().velocity = transform.forward * bulletSpeed;
        spawnedBullet.GetComponent<Bullet>().lifeTime = bulletLifeTime;
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))

        {
            Spawn();
        }
    }
}
