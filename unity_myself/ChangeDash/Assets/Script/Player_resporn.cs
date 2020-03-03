using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_resporn : MonoBehaviour {
    public Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update () {
		if(this.transform.position.x < -50 || this.transform.position.x > 50)
        {
            this.transform.position = new Vector3(0f, 2.5f, 0f);
            rb.velocity = new Vector3(0, 0, 0);
        }
        if (this.transform.position.y < -50 || this.transform.position.y > 50)
        {
            this.transform.position = new Vector3(0f, 2.5f, 0f);
            rb.velocity = new Vector3(0, 0, 0);
        }
    }
}
