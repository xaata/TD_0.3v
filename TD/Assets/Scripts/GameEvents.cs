using UnityEngine;
using UnityEngine.Events;

public class GameEvents : MonoBehaviour
{
    public static UnityEvent OnObjectChoose = new UnityEvent();
    //public delegate void ActionClick();
    //public static event ActionClick OnClickedEscapeAndMouse1;
    ////public static event Action OnClicked;
    //[SerializeField]
    //private TowerBuild towerBuild;
    //void Start()
    //{
        
    //}

    //private void OnTowerSetCancelClick()
    //{
    //    if ( (Input.GetMouseButton(1) || Input.GetKeyDown(KeyCode.Escape) ) )
    //    {
    //        if (OnClickedEscapeAndMouse1 != null)
    //        {
    //            OnClickedEscapeAndMouse1();
    //        }
    //    }
    //}
}
