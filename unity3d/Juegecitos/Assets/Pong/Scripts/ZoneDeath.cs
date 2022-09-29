using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneDeath : MonoBehaviour
{
    public int idxOpositePlayer;
    public Transform center;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            collision.gameObject.transform.position = center.position;
        }
    }
}
