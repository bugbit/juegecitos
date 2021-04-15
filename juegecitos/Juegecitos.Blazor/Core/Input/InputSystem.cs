using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juegecitos.Blazor.Core.Input
{
    public class InputSystem : IAfterUpdate
    {
        public Keyboard Keyboard { get; } = new Keyboard();

        public void AfterUpdate()
        {
            Keyboard.AfterUpdate();
        }
    }
}
