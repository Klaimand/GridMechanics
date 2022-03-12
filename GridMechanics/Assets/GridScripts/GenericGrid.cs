using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction { RIGHT, DOWN, LEFT, UP };

public class GenericGrid<T>
{
    int width = 10;
    int height = 10;
    T[,] gridArray; //for hex grids, use axial coordinates

    float cellSize = 1f;
    Vector3 origin = Vector3.zero;

    public GenericGrid(int _width, int _height, float _cellSize = 1f, Vector3 _origin = new Vector3()) //constructor
    {
        width = _width;
        height = _height;
        gridArray = new T[width, height];

        cellSize = _cellSize;
        origin = _origin;
    }

    #region Not Implemented functions

    public Vector2Int GetGridSize()
    {
        return new Vector2Int(gridArray.GetLength(0), gridArray.GetLength(1));
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
        //return all cell neighbors
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

    public List<T> GetCellsInSquare(int x, int y, int originToSideCenter)
    {
        //return all cells in a square where you go from origin to a side center in sideToCenter cells
        //(so xy is always the center of the square)
        return default;
    }

    public List<T> GetCellsOnSquare(int x, int y, int originToSideCenter)
    {
        //return all cells on a square where you go from origin to a side center in sideToCenter cells
        //(so xy is always the center of the square and will not be in the return list)
        return default;
    }

    public List<T> GetCellsInRectangle(int ax, int ay, int bx, int by)
    {
        //return all cells in a rectangle with a and b opposed corners
        return default;
    }

    public List<T> GetCellsOnRectangle(int ax, int ay, int bx, int by)
    {
        //return all cells on a rectangle with a and b opposed corners
        return default;
    }

    public virtual List<T> GetCellsOnPath(int ax, int ay, int bx, int by)
    {
        //return all cells on a path from a to b
        //here you should ungeneric this function by testing T type with that line :
        //      if (typeof(T) == typeof(string)) where string is the type you want to test
        //because you need to test something in T (most likely if its a wall)
        //to know if the cell is valid or not to walk on

        //as a second solution, you can inherit a class from GenericGrid as a non generic class
        //(for example, CellGrid does that)
        //and override this function in that class
        return default;
    }

    public virtual bool IsOnSight(int ax, int ay, int bx, int by)
    {
        //return true if a and b can see each other
        //same thing as GetCellsOnPath, you can either
        //test T type with : if (typeof(T) == typeof(string))
        //or override this function in a child class (like CellGrid does)
        return default;
    }

    #endregion

    #region Vector2Int functions (overload)
    //same functions that works with Vector2Int argument
    //they call the functions above

    public T GetCell(Vector2Int pos)
    {
        return GetCell(pos.x, pos.y);
    }

    public T GetNeighbor(Vector2Int pos, Direction _direction)
    {
        return GetNeighbor(pos.x, pos.y, _direction);
    }

    public List<T> GetNeightbors(Vector2Int pos)
    {
        return GetNeightbors(pos.x, pos.y);
    }

    public List<T> GetCellsInDistance(Vector2Int pos, int distance)
    {
        return GetCellsInDistance(pos.x, pos.y, distance);
    }

    public List<T> GetCellsInLine(Vector2Int a, Vector2Int b)
    {
        return GetCellsInLine(a.x, a.y, b.y, b.y);
    }

    public List<T> GetCellsInCircle(Vector2Int pos, int radius) //radius can maybe be float
    {
        return GetCellsInCircle(pos.x, pos.y, radius);
    }

    public List<T> GetCellsOnCircle(Vector2Int pos, int radius) //radius can maybe be float
    {
        return GetCellsOnCircle(pos.x, pos.y, radius);
    }

    public List<T> GetCellsInSquare(Vector2Int pos, int originToSideCenter)
    {
        return GetCellsInSquare(pos.x, pos.y, originToSideCenter);
    }

    public List<T> GetCellsOnSquare(Vector2Int pos, int originToSideCenter)
    {
        return GetCellsOnSquare(pos.x, pos.y, originToSideCenter);
    }

    public List<T> GetCellsInRectangle(Vector2Int a, Vector2Int b)
    {
        return GetCellsInRectangle(a.x, a.y, b.x, b.y);
    }

    public List<T> GetCellsOnRectangle(Vector2Int a, Vector2Int b)
    {
        return GetCellsOnRectangle(a.x, a.y, b.x, b.y);
    }

    public List<T> GetCellsOnPath(Vector2Int a, Vector2Int b)
    {
        return GetCellsOnPath(a.x, a.y, b.x, b.y);
    }

    #endregion

    #region Debug
    public void Drawgrid(Color _color)
    {
        //draw the grid lines and cell pos
    }

    #endregion

}
