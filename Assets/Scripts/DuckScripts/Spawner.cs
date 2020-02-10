using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DuckShoot
{
public class Spawner : MonoBehaviour
{
    public GameObject duckType;

    public float startSpawn;
    public float spawnRate;

    void Start()
    {
        InvokeRepeating("Spawn", startSpawn, spawnRate);
    }

    void Spawn()
    {
        Instantiate(duckType, transform.position, transform.rotation);
    }
}
}