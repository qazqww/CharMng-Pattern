using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseChar : MonoBehaviour, IObject<IObjectMng<BaseChar>>
{
    public IObjectMng<BaseChar> Manager { get { return manager; } }
    public CharState curState { get; set; }

    IObjectMng<BaseChar> manager;
    Animator animator;

    public virtual void Init()
    {
        animator = GetComponent<Animator>();
    }

    public void SetMng(IObjectMng<BaseChar> manager)
    {
        this.manager = manager;
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
