using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JetPac.Ship
{
    public class FuelControler : MonoBehaviour
    {
        public bool InGravity = true;
        public float Gravity = 2;
        public void ApplyGravity(bool argApply)
        {
            InGravity = argApply;
        }

        // Start is called before the first frame update
        //void Start()
        //{

        //}

        // Update is called once per frame
        //void Update()
        //{

        //}

        private void FixedUpdate()
        {
            if (!InGravity)
                return;

            var pCollider = GetComponent<BoxCollider2D>();
            var pDir = Vector2.down;
            var pDist = Gravity * Time.deltaTime;
            var pContactFilter = new ContactFilter2D();
            var pResults = new List<RaycastHit2D>();

            pContactFilter.useTriggers = true;
            pContactFilter.SetLayerMask(LayerMask.GetMask("Floor"));
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