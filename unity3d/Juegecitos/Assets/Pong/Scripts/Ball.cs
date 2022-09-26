using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rigid;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        //rigid.velocity = new Vector2(10, 10);
        rigid.AddForce(new Vector2(10, 10), ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
