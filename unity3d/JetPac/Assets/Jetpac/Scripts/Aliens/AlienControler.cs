using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JetPac.Aliens
{
    public class AlienControler : MonoBehaviour
    {
        public enum EAngleRestriction
        {
            TRAJECTORY_ANGLE_UNRESTRICTED, TRAJECTORY_ANGLE_ABOVE, TRAJECTORY_ANGLE_BELOW
        }

        public enum ECOLLISION_MODE
        {
            BOUNCE, EXPLODE
        }

        public GameObject Body;
        public GameObject Explosion;
        public ECOLLISION_MODE ColissionMode = ECOLLISION_MODE.EXPLODE;

        private Rigidbody2D mRB;
        private AudioSource mAS;

        // Start is called before the first frame update
        void Start()
        {
            mRB = GetComponent<Rigidbody2D>();
            mAS = GetComponent<AudioSource>();
            //mRB.velocity = new Vector2(-1, -1);
        }

        // Update is called once per frame
        //void Update()
        //{

        //}

        private void OnCollisionEnter2D(Collision2D collision)
        {
            switch (ColissionMode)
            {
                case ECOLLISION_MODE.EXPLODE:
                    Explode();
                    break;
            }
        }

        private void Explode()
        {
            mRB.velocity = Vector2.zero;
            mAS.enabled = true;
            Body.SetActive(false);
            Explosion.SetActive(true);
            Destroy(gameObject, 3);
        }
    }
}