using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_move : MonoBehaviour {
    public GameObject player;
    public float move_speed = 10.0f;
    public Rigidbody rb;
    public float JumpPower = 200.0f;
    public bool onGround = true;
    public Animator an;
    private float rotate_x = 0;
    private float rotate_z = 0;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        an = GetComponent<Animator>();
        an.SetBool("moving", false);
        an.SetBool("air", false);
    }
	
	// Update is called once per frame
	void Update () {
        now_rotate_get();
        move_character();
		
	}
    void now_rotate_get()
    {
        rotate_x = this.transform.localEulerAngles.x;
        rotate_z = this.transform.localEulerAngles.z;
    }
    void move_character() {//移動処理をまとめた関数
        runandjump();//走るのとジャンプ
        velocity_limit();//速度上限をかける
    }
    void runandjump()
    {
        float x_vel = Input.GetAxis("Horizontal") * move_speed;
        rb.AddForce(x_vel, 0, 0);

        if (Mathf.Abs(rb.velocity.x) >= 0.001f)
        {
            an.SetBool("moving", true);
            if (rb.velocity.x < 0)
            {
                this.gameObject.transform.rotation = Quaternion.Euler(rotate_x, -90.0f, rotate_z);//左   を向く
            }
            else
            {
                this.gameObject.transform.rotation = Quaternion.Euler(rotate_x, 90.0f, rotate_z);//右を向く
            }

        }
        else//x方向の速度が極小なら停止
        {
            an.SetBool("moving", false);
        }
        if (rb.velocity.y >= 0.001 || rb.velocity.y <= -0.001)
        {
            onGround = false;
            an.SetBool("air", true);

        }
        else//落下してないかつ上昇してないなら地上
        {
            onGround = true;
            an.SetBool("air", false);
        }
        if (onGround && Input.GetKeyDown(KeyCode.Z))
        {
            rb.AddForce(x_vel, JumpPower, 0);
            onGround = false;//多段ジャンプ防止
        }        
    }
    void velocity_limit()
    {
        if (rb.velocity.x >= 10)//速度10以上で補正
        {
            rb.velocity = new Vector3(10,rb.velocity.y,rb.velocity.z);
            Debug.Log(rb.velocity);
        }
        else if(rb.velocity.x <= -10)//速度-10以下で補正
        {
            rb.velocity = new Vector3(-10, rb.velocity.y, rb.velocity.z);
        }
    }
    
}
