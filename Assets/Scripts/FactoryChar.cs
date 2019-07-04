using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryChar : Factory
{
    

    protected override void AddObject(int tableID, Object obj)
    {

    }

    protected override Component Create(int objectType, int tableID)
    {
        return null;
    }
}
