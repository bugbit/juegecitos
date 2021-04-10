﻿#if DEBUG

using Juegecitos.Blazor.Core;
using Juegecitos.Blazor.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juegecitos.Blazor.Tests
{
    public class Test1Game : Core.Game
    {
        public override void Initialize()
        {
            base.Initialize();
            PresentationParameters.Width = 300;
            PresentationParameters.Height = 400;
        }

        public override void Render(GameTime argTime)
        {
            base.Render(argTime);
            Host.clearRect(0, 0, 300, 400);
            Host.setfillStyle("green");
            Host.fillRect(10, 50, 300, 100);
            Host.setfont("16px verdana");
            Host.strokeText($"elapsed: {argTime.ElapsedGameTime:n2} total: {argTime.TotalGameTime:n2}", 10, 80);
        }
    }
}

#endif