using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juegecitos.Blazor.Core.Components
{
    public class Component2d : Component
    {
        public GameObject2d GameObject => (GameObject2d)Owner;
    }
}
