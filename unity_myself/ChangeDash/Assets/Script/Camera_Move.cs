using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Camera_Move : MonoBehaviour {
    public GameObject Player;
    void Update () {
        Camera_Control();
	}
    void Camera_Control()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {//上押したら上の方が見えるようにカメラを少し上にずらす
            this.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y + 1.0f, -4.0f);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {//下押したら下の方が見えるようにカメラを少し下にずらす
            this.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y - 1.0f, -4.0f);
        }
        else
        {//プレイヤーを追いかけるカメラ
            this.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y + 0.1f, -4.0f);
        }
    }
}
