using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRend : MonoBehaviour
{
    private LineRenderer _lr;

    public Grid grid;

    private Vector3[] spotsArr;

    private void Start()
    {
        _lr = GetComponent<LineRenderer>();
    }

    private void Update()
    {
        int count = grid.FinalPath.Count;
        _lr.positionCount = count;
        for (int i = 0; i < count; i++) 
        {
            _lr.SetPosition(i, grid.FinalPath[i].vPosition);
        }
    }

}
