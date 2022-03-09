using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction { RIGHT, DOWN, LEFT, UP };

public class KLD_Grid<T>
{
    int width = 10;
    int height = 10;
    T[,] gridArray;

    float cellSize = 1f;
    Vector3 origin = Vector3.zero;

    public KLD_Grid(int _width, int _height, float _cellSize, Vector3 _origin) //constructor
    {
        width = _width;
        height = _height;
        gridArray = new T[width, height];

        cellSize = _cellSize;
        origin = _origin;
    }

    public T GetCell(int x, int y)
    {
        return gridArray[x, y];
    }

    public T GetNeighbor(int x, int y, Direction _direction)
    {
        //return neightbor corresponding to the direction
        return default;
    }

    public List<T> GetNeightbors(int x, int y)
    {
        //return all 4 cell neighbors
        return default;
    }

    public List<T> GetCellsInDistance(int x, int y, int distance)
    {
        //return all cells in the distance
        return default;
    }

    public List<T> GetCellsInLine(int ax, int ay, int bx, int by)
    {
        //return all cells in the line ab
        return default;
    }

    public List<T> GetCellsInCircle(int x, int y, int radius) //radius can maybe be float
    {
        //return all cells in a circle with a certain radius and origin
        return default;
    }

    public List<T> GetCellsOnCircle(int x, int y, int radius) //radius can maybe be float
    {
        //return all cells on a circle with a certain radius and origin
        return default;
    }

    public List<T> GetCellsOnPath(int ax, int ay, int bx, int by)
    {
        //return all cells on a path from a to b
        //WIPPPP
        return default;
    }

    #region Debug
    public void Drawgrid(Color _color)
    {
        //draw the grid lines and cell pos
    }

    #endregion

}
