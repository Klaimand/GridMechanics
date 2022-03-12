using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellGrid : GenericGrid<Cell>
{
    //constructor that calls the base class constructor
    public CellGrid(int _width, int _height, float _cellSize = 1f, Vector3 _origin = new Vector3()) : base(_width, _height, _cellSize, _origin) { }

    public override List<Cell> GetCellsOnPath(int ax, int ay, int bx, int by)
    {
        //here you can code you pathfinding function with specific conditions relative to the cell
        //you can for example test directly if Cell.isWall == true
        return default;
    }

    public override bool IsOnSight(int ax, int ay, int bx, int by)
    {
        //same as GetCellsOnPath, you can test directly each cell with type-specific conditions
        return default;
    }
}