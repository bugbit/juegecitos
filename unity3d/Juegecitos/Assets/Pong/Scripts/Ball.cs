using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //public Vector3 impulse = new Vector3(2, 0, 2);
    public Vector2 impulse = new Vector2(2, 2);
    public AudioClip hitSound;
    public AudioClip wallHitSound;
    public AudioClip scoreSound;

    private Vector2 initialPosition;
    private Rigidbody2D rigid;
    //private Rigidbody rigid;

    public void SetPositionInitial()
    {
        transform.position = initialPosition;
    }

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
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

    float hitFactor(Vector2 ballPos, Vector2 playerPos, float playerHeight)
    {
        // ||  1 <- at the top 
        // ||
        // ||  0 <- at the middle
        // ||
        // || -1 <- at the bottom
        return (ballPos.y - playerPos.y) / playerHeight;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        // Note: 'col' holds the collision information. If the ball was hit by a player, then:
        //   col.gameObject is the player
        //   col.transform.position is the player's position
        //   col.collider is the player's collider

        if (col.gameObject.CompareTag("Player"))
        {
            // Calculate hit Factor
            var y = hitFactor(transform.position, col.transform.position, col.collider.bounds.size.y);
            // Calculate direction, make length=1 via .normalized
            var dirX = (col.transform.position.x > 0) ? -1.0f : 1.0f;
            var direction = new Vector2(dirX, y).normalized;

            // Set Velocity with dir * speed
            rigid.velocity = direction * impulse;
            Camera.main.GetComponent<AudioSource>().PlayOneShot(hitSound);
        }
        else if (col.gameObject.CompareTag("Wall"))
            Camera.main.GetComponent<AudioSource>().PlayOneShot(wallHitSound);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ZoneDeath"))
        {
            var zoneDeath = collision.gameObject.GetComponent<ZoneDeath>();

            SetPositionInitial();
            Players.instance.UpdateScore(zoneDeath.idxOpositePlayer);
            Camera.main.GetComponent<AudioSource>().PlayOneShot(scoreSound);
        }
    }
}
