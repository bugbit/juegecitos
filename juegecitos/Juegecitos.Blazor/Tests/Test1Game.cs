#if DEBUG

using Juegecitos.Blazor.Core;
using Juegecitos.Blazor.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Juegecitos.Blazor.Core.Components;

namespace Juegecitos.Blazor.Tests
{
    public class Test1Game : Game
    {
        public class Test1Render : Component2d, IComponentRender
        {
            public void Render(GameTime argTime)
            {
                var pHost = Owner.Scene.Game.Host;

                pHost.clearRect(0, 0, 300, 400);
                pHost.setfillStyle("green");
                pHost.fillRect(10, 50, 300, 100);
                pHost.setfont("16px verdana");
                pHost.strokeText($"elapsed: {argTime.ElapsedGameTime:n2} total: {argTime.TotalGameTime:n2}", 10, 80);
            }
        }
        public override void Initialize()
        {
            base.Initialize();
            PresentationParameters.Width = 300;
            PresentationParameters.Height = 400;

            var pScene = new Scene(this);

            pScene.Objs.Add
            (
                new GameObject(pScene, new Test1Render())
            );
            PresentationParameters.MainScene = pScene;
        }

        //public override void Render(GameTime argTime)
        //{
        //    base.Render(argTime);
        //    Host.clearRect(0, 0, 300, 400);
        //    Host.setfillStyle("green");
        //    Host.fillRect(10, 50, 300, 100);
        //    Host.setfont("16px verdana");
        //    Host.strokeText($"elapsed: {argTime.ElapsedGameTime:n2} total: {argTime.TotalGameTime:n2}", 10, 80);
        //}
    }
}

#endif