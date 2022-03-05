using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeButton : MonoBehaviour
{
    private GameObject towerPrefab;
    private Sprite sprite;
    private int price;
    private Text priceTxt;

    [SerializeField] private SelectObject _selectObject;
       

    //private void SelectTowerType()
    //{
    //    var type =  _selectObject.GetSelectedObject().GetComponent<Tower>().GetTowerType();
        
    //    switch (type)
    //    {
    //        case TowerType.BasicTower:
    //            return
    //        case TowerType.BasicTower:
    //            return
    //        case TowerType.BasicTower:
    //            return
    //        case TowerType.BasicTower:
    //            return

    //    }
    //}


}
