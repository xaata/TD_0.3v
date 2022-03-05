using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Totem : MonoBehaviour
{
    protected List<Transform> GetTowersAround(float radius)
    {
        List<Transform> list = new List<Transform>();
        Collider2D[] towersInArea = Physics2D.OverlapCircleAll(transform.position, radius, 1 << LayerMask.NameToLayer("Tower"));
        foreach (Collider2D tower in towersInArea)
        {
            list.Insert(0,tower.transform);
        }
        return list;
    }

    protected void SpreadEffect(List<Transform> list, string totemName)
    {
        foreach(Transform tower in list)
        {
            AddTotemEffectToTower(tower,totemName);
        }
    }

    private void AddTotemEffectToTower(Transform tower ,string totemName)
    {
        switch (totemName)
        {
            case "EarthTotem":
                tower.gameObject.AddComponent<EarthProjectile>();
                break;
            case "FireTotem":
                tower.gameObject.AddComponent<FireProjectile>();
                break;
            case "WaterTotem":
                tower.gameObject.AddComponent<WaterProjectile>();
                break;
            case "WindToteme":
                tower.gameObject.AddComponent<WindProjectile>();
                break;

        } 
    }
    private void DestroyTotem(List<Transform> list, string totemName)
    {
        foreach (var item in list)
        {
            RemoveTotemEffect(item, totemName);
        }
        Destroy(gameObject);
    }
    private void RemoveTotemEffect(Transform tower ,string totemName)
    {
        switch (totemName)
        {
            case "EarthTotem":
                Destroy(tower.GetComponent<EarthProjectile>());
                break;
            case "FireTotem":
                Destroy(tower.GetComponent<FireProjectile>());
                break;
            case "WaterTotem":
                Destroy(tower.GetComponent<WaterProjectile>());
                break;
            case "WindToteme":
                Destroy(tower.GetComponent<WindProjectile>());
                break;

        }
    }
}
