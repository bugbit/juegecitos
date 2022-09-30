using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputHuman : MonoBehaviour
{
    private Player player;
    private float vertical = 0;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxisRaw(player.axis);
    }

    void FixedUpdate()
    {
        player.MoveToVertical(vertical);
    }
}
