using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PouseTrans : MonoBehaviour {
    public GameObject main_Camera;
    public GameObject pivot;
    public GameObject CameraRig;
    Vector3 Camera_Forward;
    Vector3 default_Piv;
    Vector3 default_Rig;
    void Update () {
        //Animator取り出し
        Animator animator = GetComponent<Animator>();
        //予め設定したboolパラメータ「PouseTrans」取り出し
        int PouseTrans = animator.GetInteger("PouseTrans");
        //カメラが向いている向きの単位ベクトル
        Camera_Forward = Vector3.Scale(Camera.main.transform.forward, new Vector3(1, 0, 1)).normalized;
        //false状態かつeキー入力でtrue(構え状態に移行)
        if (PouseTrans != 1)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {

                //pivotのもとの位置保持
                //default_Piv = pivot.transform.position;
                //Rigのもとの位置保持
                //default_Rig = pivot.transform.position;
                PouseTrans = 1;
                animator.SetInteger("PouseTrans", 1);
                pivot.transform.localPosition = new Vector3(0.0f,1.4f,0.7f);
                //CameraRig.transform.position = new Vector3(default_Rig.x-Camera_Forward.x,0.0f,default_Rig.z-Camera_Forward.z);
            }
        }
        //true状態でeキー入力するとfalse(構え解除)
        else
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                PouseTrans = -1;
                animator.SetInteger("PouseTrans", -1);
                pivot.transform.localPosition = new Vector3(0.0f, 2.0f, -3.0f);
                //pivot.transform.position = default_Piv;
                //CameraRig.transform.position = default_Rig;
            }
        }
	}
}
