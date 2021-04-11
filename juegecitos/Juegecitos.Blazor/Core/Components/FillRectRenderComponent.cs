using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juegecitos.Blazor.Core.Components
{
    public class FillRectRenderComponent : Component2d, IComponentRender
    {
        public string FillStyle { get; set; }

        public void Render(GameTime argTime)
        {
            var pHost = Owner.Scene.Game.Host;
            var pTransform = GameObject.Transform;

            pHost.setfillStyle(FillStyle);
            pHost.fillRect((int)pTransform.Position.X, (int)pTransform.Position.Y, (int)pTransform.Scale.X, (int)pTransform.Scale.Y);
        }
    }
}
