﻿using JetPac.Ship;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JetPac.Game
{
    public class Controler : MonoBehaviour
    {
        public enum EState
        {
            Menu, AssembleShip, LoadPartShip, WaitPartShip, FillShip, FillFuel, LoadFuel, WaitFuel
        }

        public EState State = EState.AssembleShip;
        public GameObject FuelPrefab;

        private ParControler mShipPartAssemble;
        private Ship.Controler mShipControler;
        private BoxCollider2D mZoneGameBoxC2D;

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
            ThrowObjFromTop(argFuel.gameObject);
            argFuel.InGravity = true;
            ChangeState(EState.FillFuel);
        }

        public void ThrowPrefabObjFromTop(GameObject argObj)
        {
            var pObj = Instantiate(argObj);
            ThrowObjFromTop(pObj);
        }

        private void ThrowObjFromTop(GameObject pObj)
        {
            var pBoundsZone = mZoneGameBoxC2D.bounds;
            var pBoundsObj = pObj.GetComponent<BoxCollider2D>().bounds;

            //pObj.transform.position = pBoundsZone.max - pBoundsObj.size - Vector3.right * pBoundsZone.size.x;
            pObj.transform.position = new Vector3(pBoundsZone.center.x - pBoundsZone.size.x / 2 + pBoundsObj.size.x + Random.value * (pBoundsZone.size.x - pBoundsObj.size.x), pBoundsZone.center.y + pBoundsZone.size.y / 2 - pBoundsObj.size.y, pObj.transform.position.z);
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
                        if (pPlayerCntl.IsLoadObj && pShipCntl.IsInShip(gameobj))
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
                        if (pPlayerCntl.IsLoadObj && pShipCntl.IsInShip(gameobj))
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
            mZoneGameBoxC2D = GameObject.Find("ZoneGame").GetComponent<BoxCollider2D>();
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
            }
        }
    }
}