using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JetPac.Ship
{
    public class RocketControler : MonoBehaviour
    {
        public AudioClip clipTakeOff;
        public AudioClip clipToLand;

        private Animator mAnimation;
        private AudioSource mAS;
        private int mLevel = 0;

        public void ResetLevel()
        {
            mLevel = 0;
            if (mAnimation != null)
                mAnimation.SetInteger("level", mLevel);
        }

        public bool NextLevel()
        {
            if (mLevel >= MaxLevel)
                return false;

            if (mAnimation != null)
                mAnimation.SetInteger("level", ++mLevel);

            return mLevel != MaxLevel;
        }

        public int MaxLevel => 6;

        public void TakeOff()
        {
            StartCoroutine(TakeOffCoroutine());
        }

        // Start is called before the first frame update
        void Start()
        {
            mAnimation = GetComponent<Animator>();
            mAS = GetComponent<AudioSource>();
        }

        // Update is called once per frame
        //void Update()
        //{

        //}

        private IEnumerator TakeOffCoroutine()
        {
            var h = transform.parent.GetComponent<BoxCollider2D>().bounds.size.y;
            var h2 = h / 8 / 16;
            mAS.PlayOneShot(clipTakeOff);

            while (mAS.isPlaying)
            {
                gameObject.transform.Translate(Vector3.up * h2);

                yield return new WaitForSeconds(1.0f / 16);
            }

            yield break;
        }
    }
}
