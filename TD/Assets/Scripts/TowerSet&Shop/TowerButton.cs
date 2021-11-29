using UnityEngine;
using UnityEngine.UI;

public class TowerButton : MonoBehaviour
{
    [SerializeField]
    private GameObject towerPrefab;
    [SerializeField]
    private Sprite sprite;
    [SerializeField]
    private int price;
    [SerializeField]
    private Text priceTxt;
    public GameObject TowerPrefab { get => towerPrefab; }
    public Sprite Sprite { get => sprite; }
    public int Price { get => price; }
    private Image towerButtonColor;



    void Start()
    {
        priceTxt.text = price + "$";
        towerButtonColor = GetComponent<Image>();
    }

    //private void PriceCheck()
    //{
    //    if (price <= GameManager.Instance.Currency)
    //    {

    //        towerBtnColor.color = Color.white;
    //        priceTxt.color = Color.white;
    //    }
    //    else
    //    {
    //        towerBtnColor.color = Color.gray;
    //        priceTxt.color = Color.gray;
    //    }
    //}

    //public void ShowInfo(string type)
    //{
    //    //string tooltip = string.Empty;
    //    //switch (type)
    //    //{
    //    //    case "Stone":
    //    //        //tooltip = string.Format()
    //    //        break;
    //    //    case "Fire":

    //    //        break;
    //    //    case "Ice":

    //    //        break;
    //    //    case "Wind":

    //    //        break;
    //    //}
    //    GameManager.Instance.SetToolTip(type);
    //    GameManager.instance.ShowStats();
    //}
    void Update()
    {
        
    }
}
