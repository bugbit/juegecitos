using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JetPac.Ship
{
    public class Controler : MonoBehaviour
    {
        public ParControler ParShip3;

        private RocketControler mRocketObj;

        public bool IsInShip(GameObject argObj)
        {
            return Mathf.Abs(argObj.transform.position.x - transform.position.x) <= 1e-2;
        }

        public void PutObjInZoneShip(GameObject argObj)
        {
            var pPos = argObj.transform.position;

            argObj.transform.parent = transform;
            argObj.transform.position = new Vector3(transform.position.x, pPos.y, pPos.z);
        }

        public void PrepareAssembleShip()
        {
            foreach (var pPar in FindObjectsOfType<ParControler>())
                pPar.gameObject.SetActive(true);

            mRocketObj.gameObject.SetActive(false);
        }

        public void PrepareForFill()
        {
            foreach (var pPar in FindObjectsOfType<ParControler>())
                pPar.gameObject.SetActive(false);

            mRocketObj.gameObject.SetActive(true);
        }

        // Start is called before the first frame update
        void Start()
        {
            mRocketObj = GetComponentInChildren<RocketControler>(true);
        }

        // Update is called once per frame
        //void Update()
        //{

        //}
    }
}
