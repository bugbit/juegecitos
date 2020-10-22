using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JetPac.Game
{
    public class Controler : MonoBehaviour
    {
        public enum EState
        {
            Menu, AssembleShip, LoadPartShip, WaitPartShip, FillShip
        }

        public EState State = EState.AssembleShip;

        private Ship.ParControler mShipPartAssemble, mShipPartAssembled;
        private Ship.Controler mShipControler;

        public void PartToAssemble(Ship.ParControler argPart)
        {
            mShipPartAssemble = argPart;
        }

        public void PartToShip(Ship.ParControler argPart)
        {
            mShipPartAssembled = argPart;
        }

        public void NextAssemble(Ship.ParControler argPart)
        {
            if (argPart == null)
                FillShip();
            else
            {
                State = EState.AssembleShip;
                PartToAssemble(argPart);
            }
        }

        public void FillShip()
        {
            State = EState.AssembleShip;
            mShipPartAssemble = null;
            mShipControler.PrepareForFill();
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
                        State = EState.LoadPartShip;
                    }
                    break;
            }
        }

        public void PlayerTriggerStay2D(GameObject gameobj, Collider2D collision)
        {
            var pPlayerCntl = gameobj.GetComponent<Player.Controler>();

            switch (State)
            {
                case EState.LoadPartShip:
                    var pShipCntl = collision.gameObject.GetComponent<Ship.Controler>();

                    if (pShipCntl != null)
                    {
                        if (pPlayerCntl.IsLoadObj && pShipCntl.IsInShip(gameobj))
                        {
                            mShipPartAssemble.InGravity = true;
                            mShipPartAssembled.PartToAdd(mShipPartAssemble);
                            mShipPartAssemble = null;

                            var pObj = pPlayerCntl.GetLoadObj();

                            pPlayerCntl.UnLoadObj();
                            pShipCntl.PutObjInZoneShip(pObj);
                            State = EState.WaitPartShip;
                        }
                    }
                    break;
            }
        }

        // Start is called before the first frame update
        void Start()
        {
            mShipControler = FindObjectOfType<Ship.Controler>();
            StartForState();
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void StartForState()
        {
            switch (State)
            {
                case EState.AssembleShip:
                    mShipPartAssembled = GameObject.Find("ship_par3").GetComponent<Ship.ParControler>();
                    mShipPartAssemble = mShipPartAssembled.PartNext;
                    break;
            }
        }
    }
}