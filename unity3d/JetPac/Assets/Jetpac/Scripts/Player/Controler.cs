using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.AssetImporters;
using UnityEngine;
using UnityEngine.Rendering;

namespace JetPac.Player
{
    public class Controler : MonoBehaviour
    {
        private Game.Controler mGameControler;
        private Animator mAnim;
        private Rigidbody2D mRB;
        private FixedJoint2D mFJ;
        private AudioSource mAS;
        private GameObject mLeft;
        private GameObject mRight;
        private GameObject mLoadParentObj;
        private GameObject mLoadObj;

        public float moveForce = 1;
        public float fireForce = 9f;
        public AudioClip clipCLink;

        private bool mInAir = true;

        public bool IsLoadObj => mLoadObj != null;

        public GameObject GetLoadObj()
        {
            return mLoadObj;
        }

        public void UpdatePlayer(float x, bool argFire)
        {
            var pInMov = x != 0;
            var pLR = x < 0;

            mInAir = argFire;
            mAnim.SetBool("inmov", pInMov);
            if (pInMov)
            {
                mAnim.SetBool("left_right", pLR);
                //mRB.AddForce(Vector2.right * x * moveForce);
                mRB.velocity = new Vector2(x * moveForce, mRB.velocity.y);
            }
            else
                mRB.velocity = new Vector2(0, mRB.velocity.y);
            mAnim.SetBool("infire", argFire);
            if (argFire)
            {
                //mAnim.SetBool("inair", true);
                //mRB.AddForce(Vector2.up * fireForce);
                mRB.velocity = new Vector2(mRB.velocity.x, fireForce);
            }
            else
                mRB.velocity = new Vector2(mRB.velocity.x, 0);
        }

        public void LoadObj(GameObject argObj)
        {
            mLoadObj = argObj;
            mAS.PlayOneShot(clipCLink);
            argObj.transform.position = mLoadParentObj.transform.position;
            argObj.transform.parent = mLoadParentObj.transform;
        }

        public void UnLoadObj()
        {
            mLoadObj.transform.parent = null;
            mLoadObj = null;
            //mFJ.enabled = false;
            //mFJ.connectedBody.constraints = RigidbodyConstraints2D.FreezePositionX;
            //mFJ.connectedBody = null;
        }

        // Start is called before the first frame update
        void Start()
        {
            mGameControler = FindObjectOfType<Game.Controler>();
            mAnim = GetComponent<Animator>();
            mRB = GetComponent<Rigidbody2D>();
            mFJ = GetComponent<FixedJoint2D>();
            mAS = GetComponent<AudioSource>();
            mLeft = GameObject.Find("left");
            mRight = GameObject.Find("right");
            mLoadParentObj = transform.Find("load").gameObject;
        }

        //private void OnCollisionStay2D(Collision2D collision)
        //{
        //    if (collision.gameObject.tag.Equals("Platform"))
        //        mAnim.SetBool("inair", false);
        //}

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag.Equals("Platform"))
            {
                if (!mInAir)
                {
                    mAnim.SetBool("inair", false);
                    mInAir = false;
                }
            }
            else
                mGameControler.PlayerCollisionEnter(gameObject, collision);
        }

        private void OnCollisionExit2D(Collision2D collision)
        {
            if (!mInAir)
                if (collision.gameObject.tag.Equals("Platform"))
                {
                    mAnim.SetBool("inair", true);
                    mInAir = true;
                }
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.name == "left")
                gameObject.transform.position = new Vector2(mRight.transform.position.x - (transform.position.x - collision.gameObject.transform.position.x), gameObject.transform.position.y);
            else if (collision.gameObject.name == "right")
                gameObject.transform.position = new Vector2(mLeft.transform.position.x - (transform.position.x - collision.gameObject.transform.position.x), gameObject.transform.position.y);
            else
                mGameControler.PlayerTriggerEnter2D(gameObject, collision);
        }

        private void OnTriggerStay2D(Collider2D collision)
        {
            mGameControler.PlayerTriggerStay2D(gameObject, collision);
        }

        // Update is called once per frame
        //void Update()
        //{

        //}        
    }
}