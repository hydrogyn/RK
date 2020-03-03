using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Time_print : MonoBehaviour {
    public GameObject time_text = null;//適用するテキストを指定
    private Text time_control;
    public int timelimit;//制限時間初期値
    public float time;//表示する残り時間
    int minite = 0;
    int seconds = 0;
    void Start()
    {
        time_control = time_text.GetComponent<Text>();
        time = (float)timelimit;//計算の為に一度float化
    }

	void Update () {
        Countdown();
        Time_arrangement();
        Time_over();
	}
    void Countdown()
    {
        time = time - Time.deltaTime;//floatの状態で計算結果を保持(int型だと小数点切り捨ての影響で時間が即溶けする)
        minite = (int)time / 60;
        seconds = (int)time - minite * 60;
    }
    void Time_over()
    {
        if (time < 0)
        {
            time = 0;//ゲームオーバー画面に遷移
            SceneManager.LoadScene("gameover");
        }
    }

    void Time_arrangement()
    {
        if (seconds < 10)
        {

            time_control.text = Convert.ToString(minite) + ":0" + Convert.ToString(seconds);
        }
        else
        {
            time_control.text = Convert.ToString(minite) + ":" + Convert.ToString(seconds);
        }
        //出力そのものはint型とする(長々とした桁は面倒)
    }
}
