using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_withCursor : MonoBehaviour {
    //別件で使おうかな
    public GameObject Camera;
    public GameObject player;
    GameObject mainCamera;
    GameObject player_char;
    float rotate_speed = 2.0f;
	
	void Start () {
        mainCamera = Camera;
        player_char = player;
	}
	
	void Update () {
        Camera_Move();
	}

    void Camera_Move()
    {
        //回転量を定義
        Vector3 rotation_degree = new Vector3(Input.GetAxis("Mouse x")*rotate_speed, Input.GetAxis("Mouse y")*rotate_speed);
        //x方向のカメラ制御
        mainCamera.transform.RotateAround(player_char.transform.position, Vector3.up, rotation_degree.x);
        //y方向のカメラ制御
        mainCamera.transform.RotateAround(player_char.transform.position,transform.right,rotation_degree.x);
    }
}
