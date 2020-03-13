using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spone_Enemy : MonoBehaviour {
    public GameObject Enemy_Chara_Prefab;
    float spone_pase = 20.0f;
    int spone_count = 5;
	void Update () {
        enemy_appear();
	}
    void enemy_appear()
    {
        int spone_judge=0;
        int spone_was = 1;
        spone_judge = (int)(Time.time / spone_pase);
        if(spone_judge == 1 && spone_count>0)
        {
            spone_judge = 0;
            spone_was++;
            var Enemy_Insetance = Instantiate<GameObject>(Enemy_Chara_Prefab, this.transform.position, Quaternion.Euler(new Vector3(0, 0, 0)));
            spone_count--;
            spone_pase = spone_was * 20f;
        }
    }
}
