using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Juegecitos.Blazor.Core;

namespace Juegecitos.Blazor.Games.PingPong
{
    public class PaddleObj : GameObject2d, IUpdate, IRender
    {
        public string Color { get; set; }
        public int Score { get; set; }

        public PaddleObj(Scene argScene) : base(argScene)
        {
        }

        public override void Initialize()
        {
            base.Initialize();
            Score = 0;
        }

        public void Update(GameTime argTime)
        {
            UpdateActions(argTime);
        }

        public void Render(GameTime argTime)
        {
            var pHost = Scene.Game.Host;
            var pTransform = Transform;

            pHost.setfillStyle(Color);
            pHost.fillRect((int)pTransform.Position.X, (int)pTransform.Position.Y, (int)pTransform.Scale.X, (int)pTransform.Scale.Y);
        }

        protected virtual void UpdateActions(GameTime argTime)
        {
        }
    }
}
