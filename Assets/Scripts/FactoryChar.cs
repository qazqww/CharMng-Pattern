using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 외부 전달 시 값이 바뀌는 경우를 방지하기 위해 구조체 사용
// (클래스는 참조 형태이기 때문에 의도치 않은 값의 변경이 발생할 수 있다)
public struct CharInfo
{
    public int hp;
    public int def;
    public int atk;
}

public class FactoryChar : Factory
{
    public FactoryChar(TableBase tableBase) : base(tableBase)
    {
        
    }

    protected override void AddObject(int tableID, Object obj)
    {

    }

    protected override Component Create(int objectType, int tableID)
    {
        uniqueCount++;

        CharInfo charInfo = new CharInfo();
        CharType charType = (CharType)objectType;
        charInfo.atk = tableDic[objectType].ToInt(tableID, "ATK");
        charInfo.def = tableDic[objectType].ToInt(tableID, "DF");
        charInfo.hp = tableDic[objectType].ToInt(tableID, "HP");
        string path = string.Empty;
        string modelName = tableDic[objectType].ToStr(tableID, "MODEL");
        // tableID 인덱스의 MODEL 명을 찾아온다.
        
        // objectType에 따라 다른 경로를 찾는다.
        switch(charType)
        {
            case CharType.HERO:
                if(tableDic.ContainsKey(objectType))
                    path = PathMng.HeroPath + modelName;
                break;
            case CharType.MON:
                if (tableDic.ContainsKey(objectType))
                    path = PathMng.MonPath + modelName;
                break;
        }

        if(string.IsNullOrEmpty(path))
            return null;

        GameObject obj = GameObject.Instantiate(Resources.Load(path)) as GameObject;
        obj.SendMessage("SetInfo", charInfo, SendMessageOptions.DontRequireReceiver);
        obj.SendMessage("Init", SendMessageOptions.DontRequireReceiver);
        // Debug.Log(obj.GetComponent<Component>());
        return obj.GetComponent<Component>();
    }
}
