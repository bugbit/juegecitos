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
        private Game.ZoneGame mZoneGame;
        private Animator mAnim;
        private BoxCollider2D mBC;
        private Rigidbody2D mRB;
        private AudioSource mAS;
        private GameObject mLoadParentObj;
        private GameObject mLoadObj;

        public float moveForce = 1;
        public float fireForce = 9f;
        public AudioClip clipCLink;
        public GameObject fire;

        private bool mIsFired = true;
        private bool mInGround = false;

        private ContactFilter2D mGroundFilter2D = new ContactFilter2D
        {
            useTriggers = true,
            useLayerMask = true
        };
        //Allocate an array with just one element capacity to store the floor when hit
        private RaycastHit2D[] hits = new RaycastHit2D[1];

        public bool IsLoadObj => mLoadObj != null;

        public GameObject GetLoadObj()
        {
            return mLoadObj;
        }

        public void UpdatePlayer(float x, bool argFire)
        {
            var pInMov = x != 0;
            var pLR = x < 0;

            mIsFired = argFire;
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
            mZoneGame = FindObjectOfType<Game.ZoneGame>();
            mAnim = GetComponent<Animator>();
            mBC = GetComponent<BoxCollider2D>();
            mRB = GetComponent<Rigidbody2D>();
            mAS = GetComponent<AudioSource>();
            mLoadParentObj = transform.Find("load").gameObject;
            mGroundFilter2D.SetLayerMask(LayerMask.GetMask("Floor"));
        }

        //private void OnCollisionStay2D(Collision2D collision)
        //{
        //    if (collision.gameObject.tag.Equals("Platform"))
        //        mAnim.SetBool("inair", false);
        //}

        private void FixedUpdate()
        {
            FixedUpdateGrounded();
        }

        private void FixedUpdateGrounded()
        {
            if (mIsFired)
            {
                if (mInGround)
                    mAnim.SetBool("inair", false);

                return;
            }
            //Laser length
            float laserLength = 0.025f;
            //Left ray start X
            float left = transform.position.x - (mBC.size.x * transform.localScale.x / 2.0f) + (mBC.offset.x * transform.localScale.x) + 0.1f;
            //Right ray start X
            float right = transform.position.x + (mBC.size.x * transform.localScale.x / 2.0f) + (mBC.offset.x * transform.localScale.x) - 0.1f;

            Vector2 startPositionLeft = new Vector2(left, transform.position.y - (mBC.bounds.extents.y + 0.05f));
            //Right ray start point
            Vector2 startPositionRight = new Vector2(right, transform.position.y - (mBC.bounds.extents.y + 0.05f));
            //The color of the ray for debug purpose
            Color rayColor = Color.red;
            //Check if the left laser hits something
            int leftCount = Physics2D.Raycast(startPositionLeft, Vector2.down, mGroundFilter2D, hits, laserLength);
            //Check if the right laser hits something
            int rightCount = Physics2D.Raycast(startPositionRight, Vector2.down, mGroundFilter2D, hits, laserLength);

            Collider2D col2DHit = null;
            //If one of the lasers hits the floor
            //if ((leftCount > 0 && hitsLeft[0].collider != null) || (rightCount > 0 && hitsRight[0].collider != null))
            if ((leftCount > 0 || rightCount > 0) && hits[0].collider != null)
            {

                //Get the object hits collider
                col2DHit = hits[0].collider;
                //Change the color of the ray for debug purpose
                rayColor = Color.green;
            }
            //Draw the ray for debug purpose
            Debug.DrawRay(startPositionLeft, Vector2.down * laserLength, rayColor);
            Debug.DrawRay(startPositionRight, Vector2.down * laserLength, rayColor);
            //If the ray hits the floor returns true, false otherwise

            var pInGround = col2DHit != null;

            if (pInGround != mInGround)
                mAnim.SetBool("inair", !pInGround);

            mInGround = pInGround;
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            //if (collision.gameObject.tag.Equals("Platform"))
            //{
            //    if (!mIsFired)
            //    {
            //        mAnim.SetBool("inair", false);
            //        mIsFired = false;
            //    }
            //}
            //else
            mGameControler.PlayerCollisionEnter(gameObject, collision);
        }

        private void OnCollisionExit2D(Collision2D collision)
        {
            if (!mIsFired)
                if (collision.gameObject.tag.Equals("Platform"))
                {
                    mAnim.SetBool("inair", true);
                    mIsFired = true;
                }
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.name == "left")
                gameObject.transform.position = new Vector2(mZoneGame.right.transform.position.x - 2 * gameObject.GetComponent<BoxCollider2D>().size.x /*(transform.position.x - collision.gameObject.transform.position.x)*/, gameObject.transform.position.y);
            else if (collision.gameObject.name == "right")
                gameObject.transform.position = new Vector2(mZoneGame.left.transform.position.x + 2 * gameObject.GetComponent<BoxCollider2D>().size.x /*(transform.position.x - collision.gameObject.transform.position.x)*/, gameObject.transform.position.y);
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