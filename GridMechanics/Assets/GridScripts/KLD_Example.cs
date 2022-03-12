using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KLD_Example : MonoBehaviour
{
    GenericGrid<int> intGrid;
    GenericGrid<float> floatGrid;
    CellGrid cellGrid;

    // Start is called before the first frame update
    void Start()
    {
        intGrid = new GenericGrid<int>(8, 12); //create a 8x12 int grid
        floatGrid = new GenericGrid<float>(12, 14, 2f, Vector3.right); //create a 12x14 float grid with a specific cellsize and origin

        cellGrid = new CellGrid(15, 15); //create a 15x15 cellgrid

        List<Cell> circle = cellGrid.GetCellsInCircle(4, 6, 3); //create a list that contains
        //cells in a circle with a specific center and radius

        //you can then apply something to those cells
        foreach (var cell in circle)
        {
            //do something to cell
        }
    }
}