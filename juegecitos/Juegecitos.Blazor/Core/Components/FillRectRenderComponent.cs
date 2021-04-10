using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juegecitos.Blazor.Core.Components
{
    public class FillRectRenderComponent : Component, IComponentRender
    {
        private Transform2d mTransform;

        public string FillStyle { get; set; }

        public override void Initialize()
        {
            base.Initialize();
            mTransform = Owner.GetComponent<Transform2d>();
        }

        public void Render(GameTime argTime)
        {
            var pHost = Owner.Game.Host;

            pHost.setfillStyle(FillStyle);
            pHost.fillRect((int)mTransform.Position.X, (int)mTransform.Position.Y, (int)mTransform.Scale.X, (int)mTransform.Scale.Y);
        }
    }
}
