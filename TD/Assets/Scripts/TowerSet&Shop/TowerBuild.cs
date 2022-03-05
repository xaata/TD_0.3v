using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Tilemaps;
public class TowerBuild : MonoBehaviour
{
    private SpriteRenderer choosenTowerSprite;
    private TowerShop towerShop;
    public Transform towers;
    [SerializeField] private CursorHandler _cursorHandler;
    private bool placeAvailable = true;
    private TowerButton clickedTowerButton { get; set; }
    public SpriteRenderer ChoosenTowerSprite { get => choosenTowerSprite; }
    private void Awake()
    {
        choosenTowerSprite = GetComponent<SpriteRenderer>();
        towerShop = GetComponentInParent<TowerShop>();
    }
    private void FixedUpdate()
    {
        transform.position = _cursorHandler.GetCursorTransform().position;
    }
    private void Update()
    {
        if (clickedTowerButton != null)
        {
            if (Input.GetMouseButtonDown(0) && placeAvailable)
            {
                PlaceTower(clickedTowerButton.TowerPrefab, transform.position, clickedTowerButton.Price, towers);
            }
            else if(Input.GetMouseButtonDown(1))
            {
                CancelChoosenTower();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (clickedTowerButton != null)
        {
            choosenTowerSprite.color = Color.red;
            placeAvailable = false;      
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (clickedTowerButton != null)
        {
            choosenTowerSprite.color = Color.green;
            placeAvailable = true;
        }
    }
    public GameObject PlaceTower(GameObject towerPrefab, Vector3 position, int Price, Transform parentTransform )
    {
        //var placePosition = _cursorHandler.GetCursorTransform().position;
        GameObject tower = Instantiate(towerPrefab, position, Quaternion.identity);
        towerShop.BuyTower(Price);
        tower.transform.SetParent(parentTransform);
        return tower;
    }

    public void ChooseTower(TowerButton TowerButton)
    {
        clickedTowerButton = TowerButton;
        choosenTowerSprite.sprite = TowerButton.Sprite;
        choosenTowerSprite.color = Color.green;
    }

    private void CancelChoosenTower()
    {
        clickedTowerButton = null;
        choosenTowerSprite.sprite = null;
    }
}
