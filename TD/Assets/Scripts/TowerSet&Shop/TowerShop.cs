using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerShop : MonoBehaviour
{
    [SerializeField]
    private Economic economic;
    public void BuyTower(float goldPrice)
    {
        economic.GoldCurrency -= goldPrice;
    }
    public void UpgradeTower(float goldPrice)
    {
        economic.GoldCurrency -= goldPrice;
    }
    public void SellTower(float goldPrice)
    {
        economic.GoldCurrency += goldPrice/2;
    }
    public void UpgradeTower(float goldPrice, float crystalPrice)
    {
        economic.GoldCurrency -= goldPrice;
        economic.CrystalCurrnecy -= crystalPrice;
    }
    public void SellTower(float goldPrice, float crystalPrice)
    {
        economic.GoldCurrency += goldPrice/2;
        economic.CrystalCurrnecy += crystalPrice;
    }
}
