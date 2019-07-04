using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TSingleton<T> : MonoBehaviour where T : TSingleton<T>
{
    static T instance;
    public static T Instance
    {
        get
        {
            if (instance == null) {
                GameObject obj = new GameObject(typeof(T).Name, typeof(T));
                if (obj != null)
                {
                    instance = obj.GetComponent<T>();
                    obj.SendMessage("Init", SendMessageOptions.DontRequireReceiver);
                }
            }
            return instance;
        }
    }
}
