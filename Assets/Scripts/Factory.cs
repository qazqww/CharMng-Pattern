using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 팩토리 패턴 : 분기문을 통해 새로운 오브젝트를 생성하는 기능을 분리한 것 (함수, 클래스 등으로)
// 절차를 작동시키는 일반 함수(재정의 X)와, 절차에서 사용되는 함수(재정의 O)로 구분
public class Factory
{
    TableBase tableBase;

    protected int uniqueCount = 0;

    protected Dictionary<int, TableBase> tableDic = new Dictionary<int, TableBase>();

    public Factory() { }
    public Factory(TableBase tableBase)
    {
        SetTableBase(tableBase);
    }

    public void SetTableBase(TableBase tableBase) { this.tableBase = tableBase; }
    public void AddTableBase(int index, TableBase tableBase)
    {
        if (!tableDic.ContainsKey(index))
            tableDic.Add(index, tableBase);
    }

    // 외부에서 접근할 수 있는 일반 함수
    public T Create<T>(int objectType, int tableID,
                          bool autoDestroy = false, float destroyTime = 0f) where T : Component
    {
        Object obj = Create(objectType, tableID);
        AddObject(tableID, obj);

        if (autoDestroy)
            Destroy(obj, destroyTime);
        return obj as T;
    }

    // 절차 함수
    protected virtual void AddObject(int tableID, Object obj)
    {

    }

    protected virtual Component Create(int objectType, int tableID)
    {
        return null;
    }

    void Destroy(Object obj, float time)
    {
        Object.Destroy(obj, time);
    }    
}