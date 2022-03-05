public class BasicTower : Tower
{
    private float _cooldown = 1;
    private float _attackRange = 4;
    private TowerType _towerType = TowerType.BasicTower;
    private void Start()
    {
        StartCoroutine(Shoot(_cooldown, _attackRange));
    }
    public override TowerType GetTowerType()
    {
        return _towerType;
    }
}
