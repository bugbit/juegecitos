using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public enum TypePlayers
    {
        Human, IA
    }

    public TypePlayers typePlayer = TypePlayers.Human;
    public float speed = 30;
    public string axis = "Vertical";
    public int score = 0;

    private Rigidbody2D rigid;
    //private float vertical;
    private TypePlayers? typePlayerOld;
    private PlayerInputHuman human;
    private PlayerInputIA ia;

    public void MoveToVertical(float vertical)
    {
        rigid.velocity = new Vector2(0, vertical) * speed;
    }

    private void Awake()
    {
        typePlayerOld = null;
        human = this.AddComponent<PlayerInputHuman>();
        human.enabled = false;
        ia = this.AddComponent<PlayerInputIA>();
        ia.enabled = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!typePlayerOld.HasValue || typePlayerOld != typePlayer)
            UpdatePlayerType();
    }

    private void UpdatePlayerType()
    {
        if (typePlayerOld.HasValue)
        {
            switch (typePlayerOld.Value)
            {
                case TypePlayers.Human:
                    human.enabled = false;
                    break;
                case TypePlayers.IA:
                    ia.enabled = false;
                    break;
            }
        }
        switch (typePlayer)
        {
            case TypePlayers.Human:
                human.enabled = true;
                break;
            case TypePlayers.IA:
                ia.enabled = true;
                break;
        }
        typePlayerOld = typePlayer;
    }

    // Update is called once per frame
    //void Update()
    //{
    //    vertical = Input.GetAxisRaw(axis);
    //}

    //private void FixedUpdate()
    //{
    //    rigid.velocity = new Vector2(0, vertical) * speed;
    //}
}
