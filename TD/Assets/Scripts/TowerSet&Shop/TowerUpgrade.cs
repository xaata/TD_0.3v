using UnityEngine;

public class TowerUpgrade : MonoBehaviour
{
    [SerializeField] private SelectObject _selectObject;
    private TowerButton _towerButton { get; set; }
    private TowerBuild _towerBuild;


    //[SerializeField] private GameObject earthTowerPrefab;
    //[SerializeField] private GameObject fireTowerPrefab;
    //[SerializeField] private GameObject windTowerPrefab;
    //[SerializeField] private GameObject waterTowerPrefab;
    //[SerializeField] private GameObject lavaTowerPrefab;
    //[SerializeField] private GameObject iceTowerPrefab;
    //[SerializeField] private GameObject lightningTowerPrefab;


    //[SerializeField] private GameObject rocketTowerPrefab;
    //[SerializeField] private GameObject machinegunTowerPrefab;
    //[SerializeField] private GameObject cryoTowerPrefab;
    //[SerializeField] private GameObject teslaTowerPrefab;
    //[SerializeField] private GameObject laserTowerPrefab;

    private void Awake()
    {
        _towerBuild = GetComponent<TowerBuild>();
    }
    public void UpgradeTower(TowerButton towerButton)
    {
        _towerButton = towerButton;
        Transform currentTransform = _selectObject.GetSelectedObject();
        _selectObject.DestroySelectedobject();
        var tower = _towerBuild.PlaceTower(_towerButton.TowerPrefab, currentTransform.position, _towerButton.Price, _towerBuild.towers);
        _selectObject.SetSelectedObject(tower.transform);
    }

    private void GetTowerType()
    {

    }
}
