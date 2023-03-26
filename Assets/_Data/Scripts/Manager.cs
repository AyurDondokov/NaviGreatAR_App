using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject map;
    public void MakeMap() 
    {
        Instantiate(map, gameObject.transform);
    }
}
