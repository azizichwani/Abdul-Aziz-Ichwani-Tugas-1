using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Wave
{
    public string waveName;
    public int noCharacter;
    public GameObject[] typeCharacter;
    public float spawnInterval;
}

public class SpawnCharacter : MonoBehaviour
{
    public Wave[] waves;
    public Transform[] spawnPoints;

    private Wave currentWave;
    private int currentWaveNumber;
    private float nextSpawnTime;

    private bool canSpawn = true;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        currentWave = waves[currentWaveNumber];
        SpawnWave();
        GameObject[] totalEnemies = GameObject.FindGameObjectsWithTag("Enemy");
        if(totalEnemies.Length == 0 && !canSpawn && currentWaveNumber+1 != waves.Length)
        {
            currentWaveNumber++;
            canSpawn = true;
        }
    }

    /*void SpawnNextWave()
    {

    }*/
        

    void SpawnWave()
    {
        if(canSpawn && nextSpawnTime < Time.time)
        {
            GameObject randomChar = currentWave.typeCharacter[Random.Range(0, currentWave.typeCharacter.Length)];
            Transform randomPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
            Instantiate(randomChar, randomPoint.position, Quaternion.identity);
            currentWave.noCharacter--;
            nextSpawnTime = Time.time + currentWave.spawnInterval;
            if(currentWave.noCharacter == 0)
            {
                canSpawn = false;
            }
        }
        
    }
}
