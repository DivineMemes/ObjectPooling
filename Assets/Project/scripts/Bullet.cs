using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float lifeTime;
    PooledObject pooledObj;

    void Start()
    {
        pooledObj = GetComponent<PooledObject>();
        StartCoroutine(disableBullet());
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Wall")
        {
            Vector3 decalSpawn = other.ClosestPoint(transform.position);
            GameObject spawnedDecal = DecalLocator.instance.pool.getObject();
            spawnedDecal.transform.position = decalSpawn;
            Vector3 dir = decalSpawn- transform.position;
            dir += decalSpawn;
            spawnedDecal.transform.forward = dir.normalized;
        }
        pooledObj.returnToPool();

    }



        IEnumerator disableBullet()
    {
        yield return new WaitForSeconds(lifeTime);
        pooledObj.returnToPool();
    }
}
