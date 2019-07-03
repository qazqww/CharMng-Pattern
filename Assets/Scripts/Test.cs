using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    void Start()
    {
        LowBase lowBase = new LowBase();
        lowBase.Load("CharTable");
        Debug.Log(lowBase.ToStr(3, "MODEL"));
        Debug.Log(lowBase.ToStr(5, "HP"));
    }

    void Update()
    {
        
    }
}
