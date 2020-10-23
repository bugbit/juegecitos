using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JetPac.Ship
{
    public class ParControler : MonoBehaviour
    {
        public bool InGravity = true;
        public float Gravity = 2;
        public ParControler PartNext;

        private Game.Controler mGameControler;

        public void ApplyGravity(bool argApply)
        {
            InGravity = argApply;
        }

        // Start is called before the first frame update
        void Start()
        {
            mGameControler = FindObjectOfType<Game.Controler>();
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            if (!InGravity)
                return;

            var pCollider = GetComponent<BoxCollider2D>();
            var pDir = Vector2.down;
            var pDist = Gravity * Time.deltaTime;
            var pContactFilter = new ContactFilter2D();
            var pResults = new List<RaycastHit2D>();

            pContactFilter.useTriggers = true;
            //contactFilter.NoFilter();
            switch (mGameControler.State)
            {
                case Game.Controler.EState.WaitPartShip:
                    pContactFilter.SetLayerMask(LayerMask.GetMask("ShipPar"));
                    break;
                default:
                    pContactFilter.SetLayerMask(LayerMask.GetMask("Floor"));
                    break;
            }
            pCollider.Raycast(pDir, pContactFilter, pResults, Mathf.Max(pDist, pCollider.size.magnitude));
            if (pResults.Count > 0)
            {
                foreach (var pResult in pResults)
                {
                    var d = pCollider.Distance(pResult.collider);

                    if (Mathf.Abs(d.distance) <= pDist)
                    {
                        pDist = d.distance;
                        InGravity = false;
                        if (mGameControler.State == Game.Controler.EState.WaitPartShip)
                            mGameControler.NextAssemble(PartNext);

                        break;
                    }
                }
            }
            //Debug.LogFormat(transform.position.ToString("N4"));
            transform.Translate(pDist * pDir);
            //Debug.LogFormat("{0} {1} {2}", pDist.ToString("N4"), transform.position.ToString("N4"), InGravity);
        }
    }
}