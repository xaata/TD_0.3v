using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridOFBuilding : MonoBehaviour
{
    private Grid grid;
    private float cellSizeX;
    private float cellSizeY;

    private void Start()
    {
        grid = GetComponent<Grid>();

    }

    private void FillGrid()
    {
        cellSizeX = grid.cellSize.x;
        cellSizeY = grid.cellSize.y;
    }

}
