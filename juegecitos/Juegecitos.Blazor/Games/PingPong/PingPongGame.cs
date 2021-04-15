using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Juegecitos.Blazor.Core;

namespace Juegecitos.Blazor.Games.PingPong
{
    public class PingPongGame : Game
    {
        public override void Initialize()
        {
            base.Initialize();
            PresentationParameters.BackColor = "white";
            PresentationParameters.Width = 600;
            PresentationParameters.Height = 400;
            PresentationParameters.MainScene = new PingPongScene(this);
        }
    }
}
