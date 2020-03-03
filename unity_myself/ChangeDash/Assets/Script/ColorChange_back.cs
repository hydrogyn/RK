using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange_back : MonoBehaviour {
    //背景色変更
    //色まで変えると目に悪いのでキャンセル
    public GameObject player;
    public bool phase = true;
	// Update is called once per frame
	void Update () {
        phase = player.GetComponent<phaseChange>().phase;//player内のphaseChangeのphaseの状態を受け取り
        if (phase)
        {
            this.GetComponent<Renderer>().material.color = Color.black;
        }
        else
        {
            this.GetComponent<Renderer>().material.color = Color.white;
        }
	}
}
