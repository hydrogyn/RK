using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class phaseChange : MonoBehaviour {
    //このスクリプトはplayerにアタッチし、重力操作までやる
    public bool phase = true;
    float rotatex = 0;
    float rotatey = 0;
    void Start () {
        Physics.gravity = new Vector3(0f, -9.81f, 0f);//重力操作
        this.GetComponent<player_move>().JumpPower = 200f;//ジャンプ方向
        this.gameObject.transform.rotation = Quaternion.Euler(0.0f, 90.0f, 0.0f);//さかさまにする(元に戻す)
    }
		
	void Update () {
        now_rotate_memo();
        change_phase();
	}

    void now_rotate_memo()
    {
        rotatex = this.transform.localEulerAngles.x;
        rotatey = this.transform.localEulerAngles.y;
    }

    void change_phase()
    {
        if (phase && Input.GetKeyDown(KeyCode.C))
        {
            phase = false;
            Physics.gravity = new Vector3(0f, 9.81f, 0f);//重力操作
            this.GetComponent<player_move>().JumpPower = -200f;//ジャンプ方向
            this.gameObject.transform.rotation = Quaternion.Euler(rotatex, rotatey, 180.0f); //さかさまにする
        }
        else if(!phase && Input.GetKeyDown(KeyCode.C))
        {
            phase = true;
            Physics.gravity = new Vector3(0f, -9.81f, 0f);//重力操作
            this.GetComponent<player_move>().JumpPower = 200f;//ジャンプ方向
            this.gameObject.transform.rotation = Quaternion.Euler(rotatex, rotatey, 0.0f);//さかさまにする(元に戻す)
        }
        Debug.Log("Phase change,now phase:" + phase);
    }
}
