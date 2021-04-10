using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Juegecitos.Blazor.Core;
using Juegecitos.Blazor.Core.Components;

namespace Juegecitos.Blazor.Games.PingPong
{
    public class ScoreRenderComponent : Component, IComponentRender
    {
        private Transform2d mTransform;
        private ScoreComponent mScore;

        public override void Initialize()
        {
            base.Initialize();
            mTransform = Owner.GetComponent<Transform2d>();
            mScore = Owner.GetComponent<ScoreComponent>();
        }
        public void Render(GameTime argTime)
        {
            var pHost = Owner.Game.Host;

            pHost.setfillStyle("#fff");
            pHost.setfont("35px sans-serif");

            pHost.fillText(mScore.Score.ToString(), (int)mTransform.Position.X, (int)mTransform.Position.Y);
        }
    }
}
