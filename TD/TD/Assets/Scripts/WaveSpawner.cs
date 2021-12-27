using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    
    public Transform[] enemyPrefab;
    public Transform spawnPoint;
    int waveCount = 5;
    int currentWave = 1;

    float countDown = 0.2f;
    float timeBetweenStacks = 0.2f;
    
    int enemyNumPerStack; 
    int stackCountInWave;
    

    private void Start()
    {
        enemyNumPerStack = waveCount * 15 / 10;
        stackCountInWave = currentWave * 5;
    }
    private void Update()
    {
        //if (countDown <= 0f)
        //{
        //    SpawnWave();
        //    countDown = timeBetweenStacks;
        //}
        //countDown -= Time.deltaTime;
    }
    public void StartWave()
    {
        StartCoroutine(SpawnEnemy());
    }
    void SpawnWave()
    {
        for (int i = 0; i < stackCountInWave; i++)
        {
            enemyNumPerStack = waveCount * 15 / 10;
            StartCoroutine("SpawnEnemy", enemyNumPerStack);
        }
    }
    IEnumerator SpawnEnemy()
    {
        int enemyType = Random.Range(0, (enemyPrefab.Length));
        Instantiate(enemyPrefab[enemyType], spawnPoint.position, spawnPoint.rotation);
        yield return new WaitForSeconds(timeBetweenStacks);
    }
}
