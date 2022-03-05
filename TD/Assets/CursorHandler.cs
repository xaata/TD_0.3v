using UnityEngine;

public class CursorHandler : MonoBehaviour
{

    void Update()
    {
        Cursor();
    }
    private void Cursor()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + new Vector3(-0.5f,-0.5f,0) ;
        float x = Mathf.RoundToInt(transform.position.x) + 0.5f;
        float y = Mathf.RoundToInt(transform.position.y) + 0.5f;
        transform.position = new Vector3(x, y, 0);
    }
    public Transform GetCursorTransform()
    {
        return transform;
    }   
}
