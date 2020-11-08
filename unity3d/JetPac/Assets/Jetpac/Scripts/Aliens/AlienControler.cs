using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JetPac.Aliens
{
    public class AlienControler : MonoBehaviour
    {
        public GameObject Body;
        public GameObject Explosion;

        // Start is called before the first frame update
        void Start()
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-1, -1);
        }

        // Update is called once per frame
        //void Update()
        //{

        //}

        private void OnCollisionEnter2D(Collision2D collision)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            GetComponent<AudioSource>().enabled = true;
            Body.SetActive(false);
            Explosion.SetActive(true);
            Destroy(gameObject, 3);
        }
    }
}