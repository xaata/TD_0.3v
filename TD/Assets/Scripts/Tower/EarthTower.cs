using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthTower : BasicTower
{
    void Start()
    {
        StartCoroutine(Shoot("EarthProjectile", 1f, 3));
    }
}
