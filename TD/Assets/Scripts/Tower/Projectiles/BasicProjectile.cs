using UnityEngine;

public class BasicProjectile : Projectile
{
    private float _projectileSpeed = 4;
    private float _damage = 10;

    private void Update()
    {       
        MoveToTarget(_projectileSpeed, CurrentTarget);
    }
    protected void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy") && collision.transform == CurrentTarget)
        {
            DamageDeal(_damage, collision.transform);
        }
    }

}
