using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class CodeListener : MonoBehaviour
{
    InputField input;

    LuaEnv env = new LuaEnv();
    // Start is called before the first frame update
    void Start()
    {
        input = GetComponent<InputField>();
        env.DoString(@"
Log = CS.UnityEngine.Debug.Log
LogError = CS.UnityEngine.Debug.LogError
Application = CS.UnityEngine.Application

"
);
        
    }

    public void RunCode()
    {
        env.DoString(input.text);
    }

    public void Clear()
    {
        input.text = "";
    }
}
