using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Titleto : MonoBehaviour {//カーソル乗せたときのボタンの色はColor Tintで指定
    public void Sceneload()
    {
        SceneManager.LoadScene("game_main");
    }
    public void manual()
    {
        SceneManager.LoadScene("manual");
    }
}
