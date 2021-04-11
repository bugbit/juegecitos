using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Juegecitos.Blazor.Core;
using Juegecitos.Blazor.Core.Components;

namespace Juegecitos.Blazor.Games.PingPong
{
    public class ScoreRenderComponent : Component2d, IComponentRender
    {
        public ScoreComponent Score { get; set; }

        public void Render(GameTime argTime)
        {
            var pHost = Owner.Scene.Game.Host;
            var pTransform = GameObject.Transform;

            pHost.setfillStyle("#fff");
            pHost.setfont("35px sans-serif");

            pHost.fillText(Score.Score.ToString(), (int)pTransform.Position.X, (int)pTransform.Position.Y);
        }
    }
}
