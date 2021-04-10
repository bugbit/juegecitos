using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Juegecitos.Blazor.Core;

namespace Juegecitos.Blazor.Games
{
    public class PingPong : Game
    {
        public override void Initialize()
        {
            base.Initialize();
            PresentationParameters.Width = 600;
            PresentationParameters.Height = 400;
        }

        public override void Render(GameTime argTime)
        {
            base.Render(argTime);
            mHost.clearRect(0, 0, 600, 400);
        }
    }
}
