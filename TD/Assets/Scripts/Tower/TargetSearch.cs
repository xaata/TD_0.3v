using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSearch : MonoBehaviour
{
    private List<Transform> SearchTarget(float attackRange)
    {
        List<Transform> targets = new List<Transform>();
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, attackRange, 1 << LayerMask.NameToLayer("Enemies"));
        
        foreach (Collider2D collider in colliders) 
        { 
            if (collider.CompareTag("Enemy"))
            {
                if (!targets.Contains(collider.transform))
                    targets.Insert(0, collider.transform);
            }
        }
        return targets;
    }
    public Transform FirstTargetLock(float attackRange)
    {

        Transform target = null;
        return target;
    }

    public Transform LastTargetLock(float attackRange)
    {
        Transform target = null;

        return target;
    }

    public Transform StrongestTargetLock(float attackRange)
    {
        Transform target = null;
        return target;
    }
    public Transform WeakestTargetLock(float attackRange)
    {
        Transform target = null;
        return target;
    }

    public Transform DefaultTargetLock(float attackRange)
    {
        List<Transform> targets = SearchTarget(attackRange);
        Transform target = null;
        if (targets.Count > 0)
        {
            target = targets[0];
            return target;
        }
        else
            return target;
    }
}
