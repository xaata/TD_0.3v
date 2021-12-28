using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicProjectile : MonoBehaviour
{

    protected EnemyHealth enemyHealth;

    private Transform currentTarget;

    public Transform CurrentTarget { get => currentTarget; set => currentTarget = value; }

    private void Start()
    {
        enemyHealth = currentTarget.GetComponent<EnemyHealth>();
    }
    protected virtual void MoveToTarget(float projectileSpeed, Transform currentTarget)
    {
        transform.position = Vector2.MoveTowards(transform.position, currentTarget.position, projectileSpeed * Time.deltaTime);
    }

    protected virtual void DamageDeal(float damage)
    {
        enemyHealth.EnemyHealthPoint -= damage;
        Destroy(gameObject);
    }
}
