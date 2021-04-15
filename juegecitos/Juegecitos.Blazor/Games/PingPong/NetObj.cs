using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Juegecitos.Blazor.Core;

namespace Juegecitos.Blazor.Games.PingPong
{
    public class NetObj : GameObject2d, IRender
    {
        public NetObj(Scene argScene) : base(argScene)
        {
        }

        public void Render(GameTime argTime)
        {
            var pHost = Scene.Game.Host;
            var pTransform = Transform;

            pHost.setfillStyle("#FFF");
            pHost.fillRect((int)pTransform.Position.X, (int)pTransform.Position.Y, (int)pTransform.Scale.X, (int)pTransform.Scale.Y);
        }
    }
}
