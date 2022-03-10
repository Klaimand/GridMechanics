using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KLD_Test : MonoBehaviour
{
    GenericGrid<int> grid;

    // Start is called before the first frame update
    void Start()
    {
        grid = new GenericGrid<int>(10, 10, 1f, Vector3.zero);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

public abstract class KLD_Cell
{
    public abstract bool IsWalkable();
}

public class KLD_WalkableCell : KLD_Cell
{
    public override bool IsWalkable()
    {
        return true;
    }
}

public interface ICell
{
    void IsWalkable();
}