using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject seeker;
    public float spawnInterval;
    public int spawnCount;
    ObjectPool pool;
    float spawnTime;
    void Start()
    {
        pool = GetComponent<ObjectPool>();
    }

    void poolSpawn()
    {
        for (int i = 0; i < spawnCount; i++)
        {
            GameObject spawnedSeeker = pool.getObject();
            spawnedSeeker.transform.position = transform.position + (Random.insideUnitSphere * spawnCount);
        }
    }
    void Spawn()
    {
        for (int i = 0; i < spawnCount; i++)
        {
            GameObject spawnedSeeker = Instantiate(seeker);
            spawnedSeeker.transform.position = transform.position + (Random.insideUnitSphere * spawnCount);
        }
    }
    // Update is called once per frame
    void Update()
    {
        spawnTime -= Time.deltaTime;
        if (spawnTime <= 0)
        {
            spawnTime = spawnInterval;
            poolSpawn();
        }

    }
}
