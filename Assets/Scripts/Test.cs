using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    void Start()
    {
        TableBase tableBase = new TableBase();
        tableBase.Load("CharTable");

        Factory factory = new FactoryChar(tableBase);
        factory.AddTableBase((int)CharType.HERO, tableBase);

        CharMng.Instance.SetFactory(factory);
        CharMng.Instance.Create((int)CharType.HERO, 1);

        // Debug.Log(lowBase.ToStr(3, "MODEL"));
        // Debug.Log(lowBase.ToStr(5, "HP"));
    }

    void Update()
    {
        
    }
}
