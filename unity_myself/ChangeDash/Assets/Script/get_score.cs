using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class get_score : MonoBehaviour {
    public GameObject print_text;//対象テキスト
    private Text score_text;
    int got_score;//スコア受け取り用変数
	
	void Start () {
        score_text = print_text.GetComponent<Text>();
        got_score = Score_print.getScore();
        score_text.text = Convert.ToString(got_score);
	}
}
