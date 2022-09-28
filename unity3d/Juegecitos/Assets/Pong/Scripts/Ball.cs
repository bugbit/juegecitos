using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //public Vector3 impulse = new Vector3(2, 0, 2);
    public Vector2 impulse = new Vector2(2, 2);

    private Rigidbody2D rigid;
    //private Rigidbody rigid;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        //rigid = GetComponent<Rigidbody>();
        //rigid.velocity = new Vector2(10, 10);
        //rigid.AddForce(impulse, ForceMode.Impulse);
        rigid.AddForce(impulse, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
