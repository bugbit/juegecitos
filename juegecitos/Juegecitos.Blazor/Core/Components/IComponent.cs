using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juegecitos.Blazor.Core.Components
{
    public delegate void ComponentPropEnabledChange(IComponent argComponent, bool argEnabledAnt, bool argEnabledAct);

    public interface IComponent : IInitialize
    {
        GameObject Owner { get; }
        bool Enabled { get; set; }
        event ComponentPropEnabledChange EnabledChange;
    }
}
