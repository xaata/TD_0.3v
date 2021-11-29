using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBuild : MonoBehaviour
{
    private BasicTower choosenTower;
    private SpriteRenderer choosenTowerSprite;

    private TowerButton clickedTowerButton { get; set; }
    public SpriteRenderer ChoosenTowerSprite { get => choosenTowerSprite; }

    private void Start()
    {
        choosenTowerSprite = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        TowerFollowsCursor();
    }
 
    private void TowerFollowsCursor()
    {
        if (choosenTowerSprite.enabled)
        {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        } 
    }

    public void Activate(Sprite sprite)// activate tower sprite to follow cursor
    {
        choosenTowerSprite.sprite = sprite;
        choosenTowerSprite.enabled = true;    
    }
    public void Deactivate()// deactivate tower sprite to follow cursor
    {
        choosenTowerSprite.enabled = false;
    }

    private void OnEnable()
    {
        GameEvents.OnClickedEscapeAndMouse1 += CancelChoosenTower;
    }
    private void OnDisable()
    {
        GameEvents.OnClickedEscapeAndMouse1 -= CancelChoosenTower;
    }

    private void CancelChoosenTower()
    {
        DropChoosenTower();
    }


    public void ChooseTower(TowerButton TowerButton)
    {
        clickedTowerButton = TowerButton;
        Activate(TowerButton.Sprite);
    }

    private void DropChoosenTower()
    {
        clickedTowerButton = null;
        Deactivate();
    }
}
