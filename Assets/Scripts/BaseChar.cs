using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CharType
{
    HERO,
    MON
}

// 템플릿 인터페이스 간에 상호 참조를 하려면
// 상호 참조를 하려는 두 클래스 중 하나는 상속받은 객체를 통해 참조한다

public class BaseChar : MonoBehaviour, IObject<IObjectMng<BaseChar>>
{
    Animator animator;

    public CharState curState { get; set; }
    public IObjectMng<BaseChar> Manager { get { return manager; } }    

    IObjectMng<BaseChar> manager;
    public void SetMng(IObjectMng<BaseChar> manager) { this.manager = manager; }
    int uniqueID = 0;
    public int UniqueID { get { return uniqueID; } }
    public void SetUniqueID(int uniqueID) { this.uniqueID = uniqueID; }

    public virtual void Init()
    {
        animator = GetComponent<Animator>();
    }

    public virtual void SetInfo(CharInfo charInfo)
    {
        Debug.Log(charInfo.hp);
        Debug.Log(charInfo.atk);
        Debug.Log(charInfo.def);
    }

    public virtual void Idle()
    {

    }

    public virtual void Run()
    {

    }

    public virtual void Move()
    {

    }

    public virtual void Move(CharDir dir, float speed)
    {

    }

    public virtual void Move(Vector3 dir, float speed)
    {

    }

    public virtual void SetDir(CharDir dir)
    {

    }

    public virtual void SetDir(Vector3 dir)
    {

    }

    public virtual void Attack()
    {

    }

    public virtual bool CheckBehavior(int layerindex, string animation)
    {
        return true;
    }
}
