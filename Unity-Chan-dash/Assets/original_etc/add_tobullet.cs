using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class add_tobullet : MonoBehaviour
{

    //カーソルに使用するテクスチャ
    [SerializeField]
    private Texture2D cursor;
    //弾のゲームオブジェクト
    [SerializeField]
    private GameObject bulletPrefab;
    //銃口
    [SerializeField]
    private Transform muzzle;
    //弾の射撃威力
    [SerializeField]
    private float bulletPower = 500f;
    // Use this for initialization
    void Start()
    {
        Cursor.SetCursor(cursor, new Vector2(cursor.width / 2, cursor.height / 2), CursorMode.ForceSoftware);

    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        transform.rotation = Quaternion.LookRotation(ray.direction);
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
    void Shot()
    {
        var bulletInstance = Instantiate<GameObject>(bulletPrefab, muzzle.position, muzzle.rotation);
        bulletInstance.GetComponent<Rigidbody>().AddForce(bulletInstance.transform.forward * bulletPower);
        Destroy(bulletInstance, 5f);
        /*Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100f, LayerMask.GetMask("enemy")))
        {
            Destroy(hit.collider.gameObject);
        }*/
    }
}
