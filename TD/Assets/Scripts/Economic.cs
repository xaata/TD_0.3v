using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Economic : MonoBehaviour
{
    private float goldCurrency = 500;
    private float crystalCurrnecy = 1;
    public float GoldCurrency { get => goldCurrency; set => goldCurrency = value; }
    public float CrystalCurrnecy { get => crystalCurrnecy; set => crystalCurrnecy = value; }
}
