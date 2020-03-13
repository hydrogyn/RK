using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_move : MonoBehaviour {


    /*private void OnCollisionEnter(Collision col)
    {
        //enemyタグに命中時敵、
        if (col.gameObject.tag == "enemy")
        {
            Destroy(gameObject);
            Destroy(col.gameObject);
        }
        //フィールド外に出たら削除
        if(gameObject.transform.position.x >= 100 || gameObject.transform.position.x <= -100)
        {
            Destroy(gameObject);
        }
        if (gameObject.transform.position.y >= 100 || gameObject.transform.position.y <= 0)
        {
            Destroy(gameObject);
        }
        if (gameObject.transform.position.z >= 100 || gameObject.transform.position.z <= -100)
        {
            Destroy(gameObject);
        }
    }*/
    private void OnTriggerEnter(Collider col)
    {
        // enemyタグに命中時敵、弾消去
        if (col.tag == "enemy")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
        //フィールド外に出たら削除
        if (gameObject.transform.position.x >= 100 || gameObject.transform.position.x <= -100)
        {
            Destroy(gameObject);
        }
        if (gameObject.transform.position.y >= 100 || gameObject.transform.position.y <= 0)
        {
            Destroy(gameObject);
        }
        if (gameObject.transform.position.z >= 100 || gameObject.transform.position.z <= -100)
        {
            Destroy(gameObject);
        }
    }
}
