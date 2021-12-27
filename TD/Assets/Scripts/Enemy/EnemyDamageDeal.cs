using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageDeal : MonoBehaviour
{
    private int enemyDamage = 10;
    //private Health playerHealth;
    //private GameObject player;

    public int EnemyDamage { get => enemyDamage; set => enemyDamage = value; }

    private void Awake()
    {
        //player = GameObject.FindWithTag("MyPlayer");
        //playerHealth = player.GetComponent<Health>();
    }

    public void DamageDeal(int EnemyDamage)
    {
        //playerHealth.TakeDamage(EnemyDamage);
    }

}
