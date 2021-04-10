using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juegecitos.Blazor.Core.Components
{
    public class Component : IComponent
    {
        public GameObject Owner { get; set; }

        public virtual void Initialize() { }
    }
}
