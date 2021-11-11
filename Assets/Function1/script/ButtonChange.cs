using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonChange : MonoBehaviour
{
    //点击事件，跳转界面
    public void Click()
    {
        Debug.Log("点击");
        SceneManager.LoadScene("Scenes/FrontPage");
    }
}
