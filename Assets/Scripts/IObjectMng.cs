using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IObjectMng<T>
{
    Dictionary<int, T> Container { get; }

    void Init();
    void UpdateDepth(); // 캐릭터가 겹칠 시 우선순위 설정
    void Pause();       // 캐릭터 작동 중지
    void Resume();
    void Notify(int msgType, int tableID);  // 관리되는 캐릭터들에게 메시지 전달 시 호출
    void DestroyAll();

    List<T> GetNear(T iChar);
}
