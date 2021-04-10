using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Juegecitos.Blazor.Core.Components;

namespace Juegecitos.Blazor.Core
{
    public class GameObject : IUpdate, IRender
    {
        public ComponentsCollection Components { get; } = new ComponentsCollection();

        public virtual void Render(GameTime argTime) => Components.Render(argTime);

        public virtual void Update(GameTime argTime) => Components.Update(argTime);
    }
}
