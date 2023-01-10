using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    //invoke or actually start the spawning in
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // set range
    public GameObject[] animalPrefabs; 
    private float spawnRangeX = 10;
    private float spawnPosZ = 20;
    private float spawnRangeZ = 10;
    private float spawnRangeZZ = 0;
    private float spawnPosX = 5;
    
    void Update()
    {
        
    }

    void SpawnRandomAnimal() 
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        Vector3 spawnPon = new Vector3(-10, 0, 5);
        Instantiate(animalPrefabs[animalIndex], spawnPon, animalPrefabs[animalIndex].transform.rotation);
        Vector3 spawnPom = new Vector3(-10, 0, 10);
        Instantiate(animalPrefabs[animalIndex], spawnPom, animalPrefabs[animalIndex].transform.rotation);
    }
}
