using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[AddComponentMenu("ARCourse/MessageLogger")]

public class MessageLogger : MonoBehaviour
{
    [SerializeField] private string _message = "Default message";

    //  [ContextMenu("LogMessageTest")]

    public void LogMessage()
    {
        Debug.Log(_message);
    }
}
