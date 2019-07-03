using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMng : TSingleton<CharMng>, IObjectMng<BaseChar>
{
    public Dictionary<int, BaseChar> Container { get; }

    public void Init()
    {

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
