using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public static partial class GFunc 
{
    [System.Diagnostics.Conditional("DEBUG_MODE")]
    public static void Log(object message)
    {
#if DEBUG_MODE
        Debug.Log(message);
#endif
    }

//    [System.Diagnostics.Conditional("DEBUG_MODE")]
//    public static void Assert(bool condition)
//    {
//#if DEBUG_MODE
//        Debug.Assert(condition);
//#endif

//    }


    //! GameObject 받아서 Text컴포넌트 찾아서 text필드 값 수정하는 함수

    public static void SetText(this GameObject target, string text)
    {
        Text textComponent = target.GetComponent<Text>();
        if (textComponent == null)
        {
            return;
        }
        textComponent.text = text;
    }
}
