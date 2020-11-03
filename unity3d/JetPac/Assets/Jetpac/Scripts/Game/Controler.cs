using JetPac.Ship;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*

https://maps.speccy.cz/map.php?id=Jetpac
https://github.com/mrcook/jetpac-disassembly/blob/master/jetpac.skool
http://frgcb.blogspot.com/2013/10/jetpac-ultimate-play-game-1983.html
https://www.icemark.com/
 
 */

namespace JetPac.Game
{
    public class Controler : MonoBehaviour
    {
        public enum EState
        {
            Menu, AssembleShip, LoadPartShip, WaitPartShip, FillShip, FillFuel, LoadFuel, WaitFuel, WaitPlayerForTakeOf, ShipTakeOf, ShipToLand
        }

        public EState State = EState.AssembleShip;
        public GameObject FuelPrefab;

        private ParControler mShipPartAssemble;
        private Ship.Controler mShipControler;
        private BoxCollider2D mZoneGameBoxC2D;
        private Player.Controler mPlayerControler;
        private ContactFilter2D mZonaShipFilter2D = new ContactFilter2D
        {
            useTriggers = true,
            useLayerMask = true
        };
        //Allocate an array with just one element capacity to store the floor when hit
        private RaycastHit2D[] hits = new RaycastHit2D[1];

        public void ChangeState(EState argState)
        {
            State = argState;
            ChangeState();
        }

        public void PartToAssemble(ParControler argPart)
        {
            mShipPartAssemble = argPart;
        }

        public void NextAssemble(ParControler argPart)
        {
            if (argPart == null)
                ChangeState(EState.FillShip);
            else
            {
                ChangeState(EState.AssembleShip);
                PartToAssemble(argPart);
            }
        }

        public void NextFuel(FuelControler argFuel)
        {
            if (mShipControler.NextFuel())
            {
                ThrowObjFromTop(argFuel.gameObject);
                argFuel.InGravity = true;
                ChangeState(EState.FillFuel);
            }
            else
            {
                Destroy(argFuel.gameObject);
                ChangeState(EState.WaitPlayerForTakeOf);
            }
        }

        public void ThrowPrefabObjFromTop(GameObject argObj)
        {
            var pObj = Instantiate(argObj);
            ThrowObjFromTop(pObj);
        }

        private void ThrowObjFromTop(GameObject pObj)
        {
            var pBoundsZone = mZoneGameBoxC2D.bounds;
            var pObjBox = pObj.GetComponent<BoxCollider2D>();
            var pBoundsObj = pObjBox.bounds;
            int pCountRay;

            do
            {
                pObj.transform.position = new Vector3(pBoundsZone.center.x - pBoundsZone.size.x / 2 + pBoundsObj.size.x + Random.value * (pBoundsZone.size.x - pBoundsObj.size.x), pBoundsZone.center.y + pBoundsZone.size.y / 2 - pBoundsObj.size.y, pObj.transform.position.z);
                pCountRay = Physics2D.Raycast(pObj.transform.position, Vector2.down, mZonaShipFilter2D, hits, 1);
            } while (pCountRay > 0);
        }

        public void PlayerCollisionEnter(GameObject gameobj, Collision2D collision)
        {
            //switch (State)
            //{               
            //}
        }

        public void PlayerTriggerEnter2D(GameObject gameobj, Collider2D collision)
        {
            switch (State)
            {
                case EState.AssembleShip:
                    if (collision.gameObject.name == mShipPartAssemble.gameObject.name)
                    {
                        gameobj.GetComponent<Player.Controler>().LoadObj(collision.gameObject);
                        ChangeState(EState.LoadPartShip);
                    }
                    break;
                case EState.FillFuel:
                    var pFuelCntl = collision.GetComponent<FuelControler>();

                    if (pFuelCntl != null)
                    {
                        gameobj.GetComponent<Player.Controler>().LoadObj(collision.gameObject);
                        pFuelCntl.InGravity = false;
                        ChangeState(EState.LoadFuel);
                    }
                    break;
                case EState.WaitPlayerForTakeOf:
                    if (collision.gameObject.CompareTag("Ship"))
                        ChangeState(EState.ShipTakeOf);
                    break;
            }
        }

        public void PlayerTriggerStay2D(GameObject gameobj, Collider2D collision)
        {
            var pPlayerCntl = gameobj.GetComponent<Player.Controler>();
            var pShipCntl = collision.gameObject.GetComponent<Ship.Controler>();

            if (pShipCntl != null)
            {
                switch (State)
                {
                    case EState.LoadPartShip:
                        if (pPlayerCntl.IsLoadObj /*&& pShipCntl.IsInShip(gameobj)*/)
                        {
                            mShipPartAssemble.InGravity = true;
                            mShipPartAssemble = null;

                            var pObj = pPlayerCntl.GetLoadObj();

                            pPlayerCntl.UnLoadObj();
                            pShipCntl.PutObjInZoneShip(pObj);
                            ChangeState(EState.WaitPartShip);
                        }
                        break;
                    case EState.LoadFuel:
                        if (pPlayerCntl.IsLoadObj /*&& pShipCntl.IsInShip(gameobj)*/)
                        {
                            var pFuelCntl = pPlayerCntl.GetLoadObj().GetComponent<FuelControler>();

                            if (pFuelCntl != null)
                            {
                                pFuelCntl.InGravity = true;
                                pPlayerCntl.UnLoadObj();
                                pShipCntl.PutObjInZoneShip(pFuelCntl.gameObject);
                                ChangeState(EState.WaitFuel);
                            }
                        }
                        break;
                }
            }
        }

        // Start is called before the first frame update
        void Start()
        {
            mShipControler = FindObjectOfType<Ship.Controler>();
            mPlayerControler = FindObjectOfType<Player.Controler>();
            mZoneGameBoxC2D = GameObject.Find("ZoneGame").GetComponent<BoxCollider2D>();
            mZonaShipFilter2D.SetLayerMask(LayerMask.GetMask("ZoneShip"));
            ChangeState();
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void ChangeState()
        {
            switch (State)
            {
                case EState.AssembleShip:
                    mShipControler.PrepareAssembleShip();
                    mShipPartAssemble = mShipControler.ParShip3.PartNext;
                    break;
                case EState.FillShip:
                    mShipPartAssemble = null;
                    mShipControler.PrepareForFill();
                    ThrowPrefabObjFromTop(FuelPrefab);
                    ChangeState(EState.FillFuel);
                    break;
                case EState.ShipTakeOf:
                    mPlayerControler.gameObject.SetActive(false);
                    mShipControler.TakeOff();
                    break;
            }
        }
    }
}