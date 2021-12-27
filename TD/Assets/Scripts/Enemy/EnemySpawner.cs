using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    private int numberOfWaves = 3;
    private int numberOfCurrentWave = 1;
    private int numberOfStackPerWave = 5;
    private int numberOfEnemyInStack = 3;
    private int enemiesRemaining;
    [SerializeField] private GameObject[] enemyPrefab;
    [SerializeField] private Transform spawnPoint;
    private List<GameObject> enemies = new List<GameObject>();

    public List<GameObject> Enemies { get => enemies; set => enemies = value; }

    public void StartWave()
    {
        StartCoroutine(SpawnStack(numberOfStackPerWave, numberOfEnemyInStack, 1, 3, 1));
    }

    private IEnumerator SpawnStack(int numberOfStackPerWave, int numberOfEnemyInStack, int enemyMinLevel, int enemyMaxLevel, int temp)
    {
        for (int i = 0; i < numberOfStackPerWave; i++)
        {
            for (int j = 0; j < numberOfEnemyInStack; j++)
            {
                GameObject tmpEnemy = Instantiate(enemyPrefab[0], spawnPoint);
                enemies.Add(tmpEnemy);
                yield return new WaitForSeconds(Random.Range(1, 2));
            }
            yield return new WaitForSeconds(Random.Range(2, 5));
        }
    }
}