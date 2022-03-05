using UnityEngine;

public class EarthProjectile : Projectile
{
    private float _projectileSpeed = 4;
    private float _damage = 10;
    private float _aoe = 0.5f;

    private void Update()
    {
        MoveToTarget(_projectileSpeed, CurrentTarget);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy") && collision.transform == CurrentTarget)
        {
            DamageDeal(_damage, CurrentTarget);
        }
    }
    protected override void DamageDeal(float damage, Transform currentTarget)
    {
        Collider2D[] splashArea = Physics2D.OverlapCircleAll(transform.position, _aoe, 1 << LayerMask.NameToLayer("Enemies"));
        foreach(Collider2D enemy in splashArea)
        {
            enemy.GetComponent<EnemyHealth>().EnemyHealthPoint -= damage;
        }
        Destroy(gameObject);
        
    }
}
