using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KLD_Test : MonoBehaviour
{
    KLD_Grid<int> grid;

    // Start is called before the first frame update
    void Start()
    {
        grid = new KLD_Grid<int>(10, 10);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
