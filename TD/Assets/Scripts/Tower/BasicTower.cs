using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicTower : TargetSearch
{
    [SerializeField] private GameObject projectilePrefab;

    protected IEnumerator Shoot(string projectileName, float cooldown, float attackRange)
    {
        while (true)
        {
            if (DefaultTargetLock(attackRange) != null)
            {
                    var projectile = GetProjectile(projectileName);
                    projectile.CurrentTarget = DefaultTargetLock(attackRange);  
            }
            yield return new WaitForSeconds(cooldown);
        }
    }

    public BasicProjectile GetProjectile(string projectileName)
    {
        switch (projectileName)
        {
            case "EarthProjectile":
                return Instantiate(projectilePrefab, transform).GetComponent<EarthProjectile>();
                break;
            //case "Fireprojectile":
            //    return Instantiate(projectilePrefab, transform).GetComponent<FireProjectile>();
            //    break;

        }
        return null;
    }
}
