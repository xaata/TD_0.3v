public class EarthTower : Tower
{
    private float _cooldown = 2f;
    private float _attackRange = 10;
    private TowerType _towerType = TowerType.EarthTower;

    void Start()
    {
        StartCoroutine(Shoot(_cooldown, _attackRange));
    }
    public override TowerType GetTowerType()
    {
        return _towerType;
    }
}
