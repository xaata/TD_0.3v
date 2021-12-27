using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    private float enemyHealthPoint;
    private float damageResistance;

    public float EnemyHealthPoint
    {
        get => enemyHealthPoint;
        set
        {
            enemyHealthPoint = value;
            if (enemyHealthPoint <= 0)
            {
                enemyHealthPoint = 0;
                EnemyDeath();
            }
        }
    }

    private void EnemyDeath()
    {
        //some animation
        //sound
        //wait
        Destroy(gameObject);
    }
}
