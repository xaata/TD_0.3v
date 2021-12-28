using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthProjectile : BasicProjectile
{

    private void Update()
    {
        MoveToTarget(4, CurrentTarget);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            DamageDeal(10);
        }
    }
    protected override void DamageDeal(float damage)
    {
        Collider2D[] splashArea = Physics2D.OverlapCircleAll(transform.position, 0.5f, 1 << LayerMask.NameToLayer("Enemies"));
        foreach(Collider2D enemy in splashArea)
        {
            enemy.GetComponent<EnemyHealth>().EnemyHealthPoint -= damage;
        }
        Destroy(gameObject);
        
    }
}
