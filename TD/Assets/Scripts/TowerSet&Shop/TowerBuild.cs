using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Tilemaps;
public class TowerBuild : MonoBehaviour
{
    private BasicTower choosenTower;
    private SpriteRenderer choosenTowerSprite;
    private TowerShop towerShop;
    [SerializeField]
    private GameObject towers;
    [SerializeField]
    private Tilemap tilemap;
    private Collision2D collision;
    private bool placeAvailable = true;

    private TowerButton clickedTowerButton { get; set; }
    public SpriteRenderer ChoosenTowerSprite { get => choosenTowerSprite; }

    private Vector3Int mousePos;

    private void Start()
    {
        choosenTowerSprite = GetComponent<SpriteRenderer>();
        towerShop = GetComponentInParent<TowerShop>();
        tilemap = GetComponent<Tilemap>();

    }
    private void Update()
    {
        TowerFollowsCursor();
        if (clickedTowerButton != null)
        {
            if (Input.GetMouseButtonDown(0) && placeAvailable)
            {
                PlaceTower();
            }
            else if(Input.GetMouseButtonDown(1))
            {
                CancelChoosenTower();
            }
        }
    }
 
    private void TowerFollowsCursor()
    {
        if (clickedTowerButton != null)
        {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + new Vector3(0.5f, 0.5f) ;
            float x = Mathf.RoundToInt(transform.position.x);
            float y = Mathf.RoundToInt(transform.position.y);
            transform.position = new Vector3(x, y, 0);
        } 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (clickedTowerButton != null)//uje ne nujen
        {
            try
            {
                choosenTowerSprite.color = Color.red;
                placeAvailable = false;
            }
            catch (Exception)
            {
                choosenTowerSprite.color = Color.red;
                //collision.gameObject.GetComponent<TilemapRenderer>(). = Color.red;
                placeAvailable = false;
            }
            
            
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



    private void PlaceTower()
    {
        GameObject tower = Instantiate(clickedTowerButton.TowerPrefab, transform.position, Quaternion.identity);
        towerShop.BuyTower(clickedTowerButton.Price);
        tower.transform.SetParent(towers.transform);
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
