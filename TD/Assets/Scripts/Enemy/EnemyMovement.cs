using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private float moveSpeed = 2;
    private int wayPointIndex;
    private Transform target;
    [SerializeField] private Transform[] wayPoints;
    private EnemyDamageDeal damageDeal;

    private void Start()
    {
        target = wayPoints[0];
        damageDeal = GetComponent<EnemyDamageDeal>();
    }
    private void MoveByPoints()
    {
        if (target != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
            if (Vector2.Distance(transform.position, target.position) <= 0.2f)
            {
                GetNextWayPoint();
            }
        }
    }
    private void GetNextWayPoint()
    {
        if (wayPointIndex >= wayPoints.Length - 1)
        {
            Destroy(gameObject);
            //damageDeal.DamageDeal(damageDeal.EnemyDamage);
            return;
        }
        wayPointIndex++;
        target = wayPoints[wayPointIndex];
    }

    private void Update()
    {
        MoveByPoints();
    }
}
