using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMng : TSingleton<CharMng>, IObjectMng<BaseChar>
{    
    public Dictionary<int, BaseChar> Container { get; }

    Factory factory;
    public void SetFactory(Factory factory) { this.factory = factory; }

    public void Init()
    {

    }

    public void Create(int charType, int tableID)
    {
        factory.Create<BaseChar>(charType, tableID);
    }

    public void UpdateDepth()
    {

    }

    public void Pause()
    {

    }

    public void Resume()
    {

    }

    public void Notify(int msgType, int tableID)
    {

    }

    public void DestroyAll()
    {

    }

    public List<BaseChar> GetNear(BaseChar iChar)
    {
        return null;
    }
}
