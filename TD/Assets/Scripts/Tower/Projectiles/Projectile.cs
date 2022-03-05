using UnityEngine;

public class Projectile : MonoBehaviour
{
    protected Transform _currentTarget;
    public Transform CurrentTarget { get => _currentTarget; set => _currentTarget = value; }

    protected virtual void MoveToTarget(float projectileSpeed, Transform currentTarget)
    {
        if (CurrentTarget != null)
            transform.position = Vector2.MoveTowards(transform.position, currentTarget.position, projectileSpeed * Time.deltaTime);
        else
            Destroy(gameObject);
    }

    protected virtual void DamageDeal(float damage, Transform currentTarget)
    {
        currentTarget.GetComponent<EnemyHealth>().EnemyHealthPoint -= damage;
        Destroy(gameObject, 0.1f);
    }
    protected virtual void CheckCollisionWithCurrentTarget()
    {
    }
}
