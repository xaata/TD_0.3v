using UnityEngine;

public class PlaceCheckHover : MonoBehaviour
{
    void Update()
    {
        FollowCursor();
    }

    private void FollowCursor()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + new Vector3(0.5f, 0.5f);
        float x = Mathf.RoundToInt(transform.position.x) ;
        float y = Mathf.RoundToInt(transform.position.y) ;
        transform.position = new Vector3(x, y, 0);
    }
}
