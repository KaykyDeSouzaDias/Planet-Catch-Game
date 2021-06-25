using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLogic : MonoBehaviour
{
    public Transform[] spawnPoint;
    public GameObject[] planets;



    int randSpawnP, randPlanets;
    public float spawnTime;

    void Start()
    {
        InvokeRepeating("SpawnPlanets", 0f, spawnTime);
    }

    void SpawnPlanets()
    {
        randSpawnP = Random.Range(0, spawnPoint.Length);
        randPlanets = Random.Range(0, planets.Length);
        Instantiate(planets[randPlanets], spawnPoint[randSpawnP].position, Quaternion.identity);
    }
}
