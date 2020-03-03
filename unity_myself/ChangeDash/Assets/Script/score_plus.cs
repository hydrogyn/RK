using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score_plus : MonoBehaviour {
    //スコアアイテムにアタッチする
    public GameObject Score_controler;
    public int Get_Point;//得点数は銅100、銀300、金500
    private void OnTriggerEnter(Collider other)//スコアアイテムとプレイヤーが触れ合うと指定したスコアを加算
    {
        if (other.CompareTag("Player"))
        {
            Score_controler.GetComponent<Score_print>().score += Get_Point;
            Destroy(gameObject);
        }
    }
}
