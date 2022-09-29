using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public enum TypePlayers
    {
        Human, IA
    }

    public TypePlayers TypePlayer = TypePlayers.Human;
    public float speed = 30;
    public string axis = "Vertical";
    public int score = 0;

    private Rigidbody2D rigid;
    private float vertical;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxisRaw(axis);
    }

    private void FixedUpdate()
    {
        rigid.velocity = new Vector2(0, vertical) * speed;
    }
}
