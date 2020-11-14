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
        public Sprite Sprite;
        public float Speed;
        public float Angle;
        public bool Dir;

        private SpriteRenderer mSRBody;
        private Rigidbody2D mRB;
        private AudioSource mAS;
        private Sprite SpriteAct;
        private float SpeedAct;
        private float AngleAct;
        private bool DirAct = true;

        // Start is called before the first frame update
        void Start()
        {
            mSRBody = Body.GetComponent<SpriteRenderer>();
            mRB = GetComponent<Rigidbody2D>();
            mAS = GetComponent<AudioSource>();
            //mRB.velocity = new Vector2(-1, -1);
        }

        // Update is called once per frame
        void Update()
        {
            if (Sprite != null && Sprite != SpriteAct)
            {
                mSRBody.sprite = Sprite;
                SpriteAct = Sprite;
            }
            if (Speed != SpeedAct || Angle != AngleAct)
            {
                mRB.velocity = Speed * new Vector2(Mathf.Sin(Angle * Mathf.Deg2Rad), Mathf.Cos(Angle * Mathf.Deg2Rad));
                SpeedAct = Speed;
                AngleAct = Angle;
            }
            if (Dir != DirAct)
            {
                if (!Dir)
                    mSRBody.flipX = true;
                DirAct = Dir;
            }
        }

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
            if (mRB != null)
                mRB.velocity = Vector2.zero;
            if (mAS != null)
                mAS.enabled = true;
            Body.SetActive(false);
            Explosion.SetActive(true);
            Destroy(gameObject, 3);
        }
    }
}