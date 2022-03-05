using System.Collections;
using UnityEngine;

public enum TowerType
{
    BasicTower = 0,
    FireTower = 1,
    EarthTower = 2,
    WaterTower = 3,
    WindTower = 4
}
public abstract class Tower : TargetSearch
{
    [SerializeField] private GameObject _projectilePrefab;

    protected IEnumerator Shoot(float cooldown, float attackRange)
    {
        while (true)
        {
            Transform target = DefaultTargetLock(attackRange);
            if (target!=null)
            {
                var projectile = Instantiate(_projectilePrefab, transform);
                projectile.GetComponent<Projectile>().CurrentTarget = target;
                if (true)
                {

                }
            }
            yield return new WaitForSeconds(cooldown);
        }
    }

    public abstract TowerType GetTowerType();
  

}
//protected IEnumerator Shoot1(float cooldown, float attackRange)
//{
//    while (true)
//    {
//        if (_targetLocked)
//        {

//        }
//    }
//}

//public BasicProjectile GetProjectile(GameObject projectile,TowerType type)
//{
//    switch (type)
//    {
//        case TowerType.BasicTower:
//            return _projectilePrefab.GetComponent<BasicProjectile>();
//        case TowerType.FireTower:
//            return Instantiate(_projectilePrefab, transform).GetComponent<FireProjectile>();
//            break;
//        case TowerType.EarthTower:
//            return Instantiate(_projectilePrefab, transform).GetComponent<EarthProjectile>();
//            break;

//    }
//    return null;
//}

//protected void GetProjectileType(string projectileName)
//{
//    switch (projectileName)
//    {
//        case "BasicProjectile":
//            return Instantiate(_projectilePrefab, transform).GetComponent<BasicProjectile>();
//            break;
//        case "EarthProjectile":
//            return Instantiate(_projectilePrefab, transform).GetComponent<EarthProjectile>();
//            break;
//        case "FireProjectile":
//            return Instantiate(_projectilePrefab, transform).GetComponent<FireProjectile>();
//            break;

//    }
//    return null;
//}

