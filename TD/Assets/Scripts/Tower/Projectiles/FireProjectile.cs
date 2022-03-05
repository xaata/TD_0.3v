using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireProjectile : Projectile
{
    private float _dps = 2;
    private float _burnDuration = 3;
    private float _projectileSpeed = 4;
    private float _aoe = 0.5f;

    void Update()
    {
        MoveToTarget(_projectileSpeed, CurrentTarget);
    }

    protected void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy") && collision.transform == CurrentTarget)
        {
            SetFire(_dps, _burnDuration);
        }
    }

    private void SetFire(float dps, float duration)
    {
        Collider2D[] splashArea = Physics2D.OverlapCircleAll(transform.position, _aoe, 1 << LayerMask.NameToLayer("Enemies"));
        List<EnemyHealth> enemiesHealth = new List<EnemyHealth>();
        foreach (Collider2D enemy in splashArea)
        {
            enemiesHealth.Add(enemy.GetComponent<EnemyHealth>());           
        }
        StartCoroutine(DamageDealPerTick(enemiesHealth,dps,duration));
        Destroy(gameObject);
    }

    private IEnumerator DamageDealPerTick(List<EnemyHealth> enemyHealth, float dps, float duration)
    {
        for (int i = 0; i < duration; i++)
        {
            foreach (EnemyHealth enemy in enemyHealth)
                enemy.EnemyHealthPoint -= dps;
            yield return new WaitForSeconds(1f);
        }    
    } 
}
