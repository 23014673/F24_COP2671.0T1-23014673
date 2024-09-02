using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs;

    private float spawnRangeX = 20;

    private float spawnPosZ = 20;

    private float startDelay = 2;

    private float spawnInterval = 1.5f;

    //public int animalIndex;

    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal",startDelay, spawnInterval);
    }

    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.S)) 
        {
            SpawnRandomAnimal();
        }*/
    }

    void SpawnRandomAnimal()
    {
            int animalIndex = Random.Range(0,animalPrefabs.Length);

            UnityEngine.Vector3 spawnPos = new UnityEngine.Vector3(Random.Range(-spawnRangeX,spawnRangeX),0,spawnPosZ);

            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}