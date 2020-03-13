using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {

    //カーソルに使用するテクスチャ
    [SerializeField]
    private Texture2D cursor;
	// Use this for initialization
	void Start () {
        Cursor.SetCursor(cursor, new Vector2(cursor.width / 2, cursor.height / 2), CursorMode.ForceSoftware);
		
	}
	
	// Update is called once per frame
	void Update () {
        Target_Move();
        
	}
    void Target_Move()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 10f, LayerMask.GetMask("player")))
        {
            Cursor.visible = false;
        }
        else
        {
            Cursor.visible = true;
        }
        //左クリックで射撃
        if (Input.GetButtonDown("Fire1"))
        {
            Shot();
        }
    }
    //射撃時の処理
    void Shot() {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(Physics.Raycast(ray,out hit, 100f, LayerMask.GetMask("enemy")))
        {
            Destroy(hit.collider.gameObject);
        }
    }
}
