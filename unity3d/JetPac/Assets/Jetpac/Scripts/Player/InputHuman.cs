using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JetPac.Player
{
    public class InputHuman : MonoBehaviour
    {
        private Controler mControler;

        // Start is called before the first frame update
        void Start()
        {
            mControler = GetComponent<Controler>();
        }

        private void FixedUpdate()
        {
            var x = Input.GetAxis("Horizontal");
            var y = Input.GetAxis("Vertical");

            mControler.UpdatePlayer(x, y > 0);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
