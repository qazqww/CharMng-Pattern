using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    void Start()
    {
        TableBase heroTable = new TableBase();
        heroTable.Load("CharTable");
        TableBase monTable = new TableBase();
        monTable.Load("MonTable");

        Factory factory = new FactoryChar(heroTable);
        factory.AddTableBase((int)CharType.HERO, heroTable);
        factory.SetTableBase(monTable);
        factory.AddTableBase((int)CharType.MON, monTable);

        CharMng.Instance.SetFactory(factory);
        CharMng.Instance.Create((int)CharType.HERO, 1);
        CharMng.Instance.Create((int)CharType.HERO, 2);
        CharMng.Instance.Create((int)CharType.MON, 1);
        CharMng.Instance.Create((int)CharType.MON, 2);
    }

    void Update()
    {
        
    }
}
