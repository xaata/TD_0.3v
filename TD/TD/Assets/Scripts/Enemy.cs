using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float speed = 10.0f;
    private Transform targetWayPoint;
    private int wayPointIndex = 0;
    [SerializeField]
    public WayPoints wayPoints;

    private void Awake()
    {
        
    }
    void Start()
    {

        targetWayPoint = wayPoints.points[0];
        var abc = wayPoints.gameObject.GetComponentsInChildren<Transform>();
    }
    void Move()
    {
        Vector3 direction = targetWayPoint.position - transform.position;
        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
        if (Vector3.Distance(targetWayPoint.position, transform.position) <= 0.2f)
            GetNextWayPoint();
    }
    void GetNextWayPoint()
    {
        if (wayPointIndex >= wayPoints.points.Length - 1)
        {
            Destroy(gameObject);
            return;
        }
        wayPointIndex++;
        targetWayPoint = wayPoints.points[wayPointIndex]; 
    }
    void Update()
    {
        Move(); 
    }
}
