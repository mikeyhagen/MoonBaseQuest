using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    [Header("Size of spawn area")]
    public Vector3 size;

    [Header("Rate of instantiation")]
    public float spawnRate = 1f;

    public GameObject asteroidModel;

    public Transform asteroidParent;

    private float nextSpawn = 0;

    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(0,1,0,0.5f);
        Gizmos.DrawCube(transform.position, size);
    }


    private void Update()
    {
        //Timer to control the spawning
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;

            SpawnAnAsteroid();
        }
    }

    private void SpawnAnAsteroid()
    {
        Vector3 spawnPoint = transform.position + new Vector3(UnityEngine.Random.Range(-size.x / 2, size.x / 2),
                                                             UnityEngine.Random.Range(-size.y / 2, size.y / 2),
                                                             UnityEngine.Random.Range(-size.z / 2, size.z / 2));


        //Quaternion asteroidRotation = Quaternion.Euler(UnityEngine.Random.Range(0, 360), UnityEngine.Random.Range(0, 360), UnityEngine.Random.Range(0, 360));

        GameObject asteroid = Instantiate(asteroidModel, spawnPoint, transform.rotation);

        asteroid.transform.SetParent(asteroidParent);


    }
}
