using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JetPac.Aliens
{
    public class AliensManager : MonoBehaviour
    {
        public enum EAngleRestriction
        {
            ALIEN_TRAJECTORY_ANGLE_UNRESTRICTED, ALIEN_TRAJECTORY_ANGLE_ABOVE, ALIEN_TRAJECTORY_ANGLE_BELOW
        }

        private Game.Controler mGameControler;

        public GameObject alienPrefab;
        public Sprite[] alienSprites;
        public GameObject aliens;
        public int startNumAliens;
        public int angleMin = 0;
        public int angleMax = 20;
        public EAngleRestriction angleRestriction = EAngleRestriction.ALIEN_TRAJECTORY_ANGLE_UNRESTRICTED;
        public float speedMin = 100;
        public float speedMax = 200;
        public float alienRespawmLikeHood = 0.95f;

        public void generateAliens(int argNumAliens)
        {
            for (var i = 0; i < argNumAliens; i++)
                generateAlien();
        }

        public void generateAlien()
        {
            var pSpriter = alienSprites[Random.Range(0, alienSprites.Length)];
            var pAngle = Random.Range(angleMin, angleMax);
            var pUpDown = angleRestriction == EAngleRestriction.ALIEN_TRAJECTORY_ANGLE_ABOVE;
        }

        // Start is called before the first frame update
        void Start()
        {
            mGameControler = FindObjectOfType<Game.Controler>();
            generateAliens(startNumAliens);
        }

        // Update is called once per frame
        void Update()
        {
            if (!mGameControler.HaltRespawning)
            {
                var pNumAliens = startNumAliens - aliens.transform.childCount;

                if (pNumAliens > 0)
                {
                    if (Random.value > alienRespawmLikeHood)
                        generateAliens(1);
                }
            }
        }
    }
}