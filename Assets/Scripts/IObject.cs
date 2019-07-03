using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CharState {
    Idle,
    Move,
    Attack,
    AttackWait
}

public enum CharDir
{
    LEFT,
    RIGHT,
    UP,
    DOWN
}

public interface IObject<T>
{
    T Manager { get; }

    CharState curState { get; set; }

    void Init();
    void SetMng(T manager);
    void Idle();
    void Run();
    void Move();
    void Move(CharDir dir, float speed);
    void Move(Vector3 dir, float speed);
    void SetDir(CharDir dir);
    void SetDir(Vector3 dir);
    void Attack();
    bool CheckBehavior(int layerindex, string animation);    
}

/* interface와 abstract(추상 클래스)의 차이
 * 
 * 기본적으로 C#에서 클래스는 다중 상속을 허용하지 않는다.
 * interface는 여러 개를 상속받을 수 있다.
 * interface는 모두 public 형태로 상속, 구현된다.
 * interface는 상속받은 객체까지만 재정의할 수 있다.
 * abstract는 하위 클래스에서 접근 가능하도록 상속한다면(protected 이상) 모두 재정의할 수 있다.
 */