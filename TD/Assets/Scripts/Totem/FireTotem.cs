using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireTotem : Totem
{
    // Start is called before the first frame update
    void Start()
    {
        SpreadEffect(GetTowersAround(5), "FireTotem");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
