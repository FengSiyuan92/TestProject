using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LookLog : MonoBehaviour
{

    Text text;
    string content = "";
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        Application.logMessageReceived += CollectLog;
        text.text = content;
    }

    void CollectLog(string condition, string stackTrace, LogType type)
    {
        if (type == LogType.Error)
        {
            content += "\n Error:" + condition;
        }
        else if (type == LogType.Exception)
        {
            content += "\n Exception:" + condition  ;
        }
        else if (type == LogType.Log)
        {
            content += "\n Log:" + condition ;
        }

        text.text = content;
    }

    public void Clear()
    {
        content = "";
        text.text = content;
    }

}
