using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float healthPoint;
    private float moveSpeed = 10;
    private float damage;
    private float statusResist;
    private float damageResist;

    private int wayPointIndex;

    private Transform target;

    [SerializeField]
    private Transform[] wayPoints;

    private void Start()
    {
       target = wayPoints[0];
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
