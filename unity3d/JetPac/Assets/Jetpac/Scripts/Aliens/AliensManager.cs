using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JetPac.Aliens
{
    public class AliensManager : MonoBehaviour
    {
        private Game.Controler mGameControler;
        private Game.ZoneGame mZoneGame;

        public AlienControler alienPrefab;
        public Sprite[] alienSprites;
        public GameObject aliens;
        public int startNumAliens;
        public int angleMin = 0;
        public int angleMax = 20;
        public AlienControler.EAngleRestriction angleRestriction = AlienControler.EAngleRestriction.TRAJECTORY_ANGLE_UNRESTRICTED;
        public float speedMin = 100;
        public float speedMax = 200;
        public AlienControler.ECOLLISION_MODE ColissionMode = AlienControler.ECOLLISION_MODE.EXPLODE;
        public bool alienTrails;
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
            float pUpDown;
            var pDir = Random.Range(0, 2) == 2; // true => right
            var pSpeed = Random.Range(speedMin, speedMax);
            float pXOrd, pYOrd;

            switch (angleRestriction)
            {
                case AlienControler.EAngleRestriction.TRAJECTORY_ANGLE_ABOVE:
                    pUpDown = 0.5f;
                    break;
                case AlienControler.EAngleRestriction.TRAJECTORY_ANGLE_BELOW:
                    pUpDown = 1.5f;
                    break;
                default:
                    pUpDown = Random.Range(0.0f, 2.0f);
                    break;
            }
            if (pDir)
            {
                if (pUpDown < 1)
                    pAngle = 360 - pAngle;
                pXOrd = mZoneGame.right.transform.position.x - 2 * pSpriter.bounds.size.x;
            }
            else
            {
                if (pUpDown < 1)
                    pAngle = 170 + pAngle;
                else
                    pAngle = 170 + pAngle;
                pXOrd = mZoneGame.left.transform.position.x + 2 * pSpriter.bounds.size.x;
            }
            pYOrd = mZoneGame.top.transform.position.y + 2 * pSpriter.bounds.size.y + Random.Range(0, mZoneGame.bottom.transform.position.y - mZoneGame.top.transform.position.y - 2 * pSpriter.bounds.size.y);

            var pAlien = Instantiate<AlienControler>(alienPrefab, new Vector3(pXOrd, pYOrd), Quaternion.identity, aliens.transform);

            pAlien.ColissionMode = ColissionMode;
            pAlien.Sprite = pSpriter;
            pAlien.Speed = pSpeed;
            pAlien.Angle = pAngle;
            pAlien.Dir = pDir;
        }

        // Start is called before the first frame update
        void Start()
        {
            mGameControler = FindObjectOfType<Game.Controler>();
            mZoneGame = FindObjectOfType<Game.ZoneGame>();
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