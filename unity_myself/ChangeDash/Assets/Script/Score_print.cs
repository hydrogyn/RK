using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Score_print : MonoBehaviour {
    public GameObject score_text=null;//適用するテキストを指定
    private Text score_control;
    public int score=0;//表示するスコア
    public static int submit_score=0;
    void Start()
    {
        score_control = score_text.GetComponent<Text>();
    }
    void Update () {
        score_control.text =Convert.ToString(score);
        submit_score = score;
	}
    public static int getScore()
    {
        return submit_score;
    }
}
