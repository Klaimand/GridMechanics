using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KLD_Grid<T>
{
    int width = 10;
    int height = 10;

    T[,] gridArray;

    public KLD_Grid(int _width, int _height)
    {
        width = _width;
        height = _height;
        gridArray = new T[width, height];
    }
}
