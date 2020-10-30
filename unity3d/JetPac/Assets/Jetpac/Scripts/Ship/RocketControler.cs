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
            var a = gameObject.transform.position;
            var b = a + Vector3.up * (transform.parent.GetComponent<BoxCollider2D>().size.y - 2 * GetComponent<BoxCollider2D>().size.y);
            var t = 0.0f;

            mAS.PlayOneShot(clipTakeOff);

            while (mAS.isPlaying)
            {
                t += Time.deltaTime;
                gameObject.transform.position = Vector3.Lerp(a, b, t / 8.0f);

                yield return null;
            }

            yield break;
        }
    }
}
