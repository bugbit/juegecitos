using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputIA : MonoBehaviour
{
    public float distanceMin = 0.1f;

    private Player player;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        var ball = Ball.instance.transform;
        var distance = Mathf.Abs(ball.position.y - transform.position.y);

        if (distance > distanceMin)
        {
            if (ball.position.y > transform.position.y)
                player.MoveToVertical(1);

            if (ball.position.y < transform.position.y)
                player.MoveToVertical(-1);
        }
    }
}
