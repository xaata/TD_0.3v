using UnityEngine;

public class SelectObject : MonoBehaviour
{
    [SerializeField] private Material _highlightMaterial;
    [SerializeField] private GameObject _elementalTowerUpgradePanel;
    [SerializeField] private GameObject _fireTowerUpgradePanel;
    [SerializeField] private GameObject _earthTowerUpgradePanel;
    [SerializeField] private GameObject _waterTowerUpgradePanel;
    [SerializeField] private GameObject _windTowerUpgradePanel;
    private Transform _selection;
    private Transform _currentSelectedObject;
    private Transform _previousSelectedObject;
    private bool _selected = false;
    private string _tag;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit2D = Physics2D.Raycast(transform.position, Vector2.down, 0.0f, LayerMask.GetMask("Enemies", "Tower"));                      
            if (hit2D.collider != null)
            {
                var _hit2DCol = hit2D.collider;
                _currentSelectedObject = hit2D.transform;
                SpriteRenderer _currentSprite = _currentSelectedObject.GetComponent<SpriteRenderer>();
                if (!_selected)
                {
                    _currentSprite.color = Color.blue;
                    _selected = true;                   
                    _previousSelectedObject = _currentSelectedObject;
                    _tag = _currentSelectedObject.tag;
                }
                else
                {
                    _previousSelectedObject.GetComponent<SpriteRenderer>().color = Color.white;
                    _currentSprite.color = Color.blue;
                    _previousSelectedObject = _currentSelectedObject;
                    _tag = _currentSelectedObject.tag;
                }
                if (_hit2DCol.CompareTag("ElementalTower"))
                {    
                    _elementalTowerUpgradePanel.SetActive(true);                     
                }
                if (_hit2DCol.CompareTag("FireTower"))
                {

                }
                
                switch (_tag)
                {
                    case "ElemetalTower":
                        _elementalTowerUpgradePanel.SetActive(true);
                        break;
                    //case "fireTower":
                    //    _elementalTowerUpgradePanel.SetActive(true);
                    //    break;
                    //case "earthTower":
                    //    _elementalTowerUpgradePanel.SetActive(true);
                    //    break;
                    //case "waterTower":
                    //    _elementalTowerUpgradePanel.SetActive(true);
                    //    break;
                    //case "windTower":
                    //    _elementalTowerUpgradePanel.SetActive(true);
                    //    break;
                }
            }
                       
        }
        if (Input.GetMouseButtonDown(1))
        {
            if (_currentSelectedObject != null && _selected)
            {
                _currentSelectedObject.GetComponent<SpriteRenderer>().color = Color.white;
                _selected = false;
                _elementalTowerUpgradePanel.SetActive(false);
            }
            
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }
    public Transform GetSelectedObject()
    {
        return _currentSelectedObject;
    }
    public Transform SetSelectedObject(Transform other)
    {
        return _currentSelectedObject = other;
    }
    public void DestroySelectedobject()
    {
        switch (_tag)
        {
            case "ElementalTower":
                _elementalTowerUpgradePanel.SetActive(false);
                break;
            case "fireTower":
                _elementalTowerUpgradePanel.SetActive(false);
                break;
            case "earthTower":
                _elementalTowerUpgradePanel.SetActive(false);
                break;
            case "waterTower":
                _elementalTowerUpgradePanel.SetActive(false);
                break;
            case "windTower":
                _elementalTowerUpgradePanel.SetActive(false);
                break;
        }
        Destroy(_currentSelectedObject.gameObject);
        _selected = false;
       
    }
}
