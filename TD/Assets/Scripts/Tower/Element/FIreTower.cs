public class FIreTower : Tower
{
    private float _cooldown = 1f;
    private float _attackRange = 5;
    private TowerType _towerType = TowerType.FireTower;
    void Start()
    {
        StartCoroutine(Shoot(_cooldown, _attackRange));
    }
    public override TowerType GetTowerType()
    {
        return _towerType;
    }
}
