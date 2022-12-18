using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Juegecitos.Blazor.Core;

namespace Juegecitos.Blazor.Games.PingPong
{
    public class ScoreObj : GameObject2d, IRender
    {
        public PaddleObj Paddle { get; set; }

        public ScoreObj(Scene argScene) : base(argScene)
        {
        }

        public void Render(GameTime argTime)
        {
            var pHost = Scene.Game.Host;
            var pTransform = Transform;

            pHost.setfillStyle("#fff");
            pHost.setfont("35px sans-serif");

            pHost.fillText(Paddle.Score.ToString(), (int)pTransform.Position.X, (int)pTransform.Position.Y);
        }
    }
}
