using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public int numberOfWaves = 3;
    public int numberOfStackPerWave = 5;
    public int numberOfEnemyInStack = 3;

    [SerializeField] private GameObject[] enemyPrefab;
    [SerializeField] private Transform spawnPoint;
    private void Start()
    {
        for (int i = 0; i < numberOfStackPerWave; i++)
        {
            for (int j = 0; j < numberOfEnemyInStack; j++)
            {
                GameObject tmpEnemy = Instantiate(enemyPrefab[0], spawnPoint);
            }
        }
    }
    private void Update()
    {
        
    }
}
