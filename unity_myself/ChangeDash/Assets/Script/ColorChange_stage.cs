using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange_stage : MonoBehaviour {
    //足場の色変更
    //色まで変えると目に悪いのでキャンセル
    public GameObject player;
    public bool phase = true;
	// Update is called once per frame
	void Update () {
        phase = player.GetComponent<phaseChange>().phase;//player内のphaseChangeのphaseの状態を受け取り
        if (phase)
        {
            foreach(Transform child in transform)//子要素つかってforeach
            {
                child.GetComponent<Renderer>().material.color = Color.white;
            }
        }
        else
        {
            foreach (Transform child in transform)
            {
                child.GetComponent<Renderer>().material.color = Color.black;
            }
        }
    }
}
