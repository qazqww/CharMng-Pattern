using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CharType
{
    HERO,
    MON
}

public class Test : MonoBehaviour
{
    void Start()
    {
        LowBase lowBase = new LowBase();
        lowBase.Load("CharTable");        

        // Debug.Log(lowBase.ToStr(3, "MODEL"));
        // Debug.Log(lowBase.ToStr(5, "HP"));
    }

    void Update()
    {
        
    }

    BaseChar CreateChar(CharType charType, int id)
    {
        BaseChar ch = null;
        switch(charType)
        {
            case CharType.HERO:
                ch = new BaseChar();
                break;
            case CharType.MON:
                ch = new BaseChar();
                break;
        }

        return ch;
    }
}
