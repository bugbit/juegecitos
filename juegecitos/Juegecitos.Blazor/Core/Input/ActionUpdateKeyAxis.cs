using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace Juegecitos.Blazor.Core.Input
{
    public class ActionUpdateKeyAxis : ActionUpdateAxis
    {
        public string Key { get; set; }
        public string KeyCode { get; set; }

        protected override bool IsOk(InputSystem argInput)
        {
            var pKey =
                (Key != null)
                    ? argInput.Keyboard.GetKeyInfo(Key)
                    : (KeyCode != null)
                        ? argInput.Keyboard.GetKeyCodeInfo(KeyCode)
                        : KeyInfo.None;

            return pKey.State == EButtonState.Down;
        }
    }
}
