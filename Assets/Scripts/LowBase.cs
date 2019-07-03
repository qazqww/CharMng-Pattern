using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowBase
{
    Dictionary<int, Dictionary<string, string>> textDic = new Dictionary<int, Dictionary<string, string>>();

    public void Load(string path)
    {
        TextAsset textAsset = Resources.Load<TextAsset>(path);
        string[] rows = textAsset.text.Split('\n');
        int count = rows.Length;
        if(string.IsNullOrEmpty(rows[rows.Length - 1])) // 개행으로 나온 마지막 row를 제외
            count--;

        for(int i=0; i<count; i++)
            rows[i] = rows[i].Replace("\r", "");

        string[] subject = rows[0].Split(',');

        for(int i=1; i<count; i++)
        {
            string[] cols = rows[i].Split(',');

            int mainKey = -1;
            int.TryParse(cols[0], out mainKey);

            if(!textDic.ContainsKey(mainKey))
                textDic.Add(mainKey, new Dictionary<string, string>());

            for(int j=1; j<cols.Length; j++)
            {
                if (!textDic[mainKey].ContainsKey(subject[j]))
                    textDic[mainKey].Add(subject[j], cols[j]);
            }
        }
    }

    public string ToStr(int mainKey, string subStr)
    {
        if (textDic.ContainsKey(mainKey))
        {
            if (textDic[mainKey].ContainsKey(subStr))
                return textDic[mainKey][subStr];                    
        }
        return string.Empty;
    }

    public int ToInt(int mainKey, string subStr)
    {
        if (textDic.ContainsKey(mainKey))
        {
            if (textDic[mainKey].ContainsKey(subStr))
            {
                int val = 0;
                int.TryParse(textDic[mainKey][subStr], out val);
                return val;
            }
        }
        return -1;
    }

    public float ToFloat(int mainKey, string subStr)
    {
        if (textDic.ContainsKey(mainKey))
        {
            if (textDic[mainKey].ContainsKey(subStr))
            {
                float val = 0;
                float.TryParse(textDic[mainKey][subStr], out val);
                return val;
            }
        }
        return -1;
    }
}
