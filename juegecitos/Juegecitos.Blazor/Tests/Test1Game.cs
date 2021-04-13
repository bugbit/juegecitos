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
        private class Scene1 : Scene
        {
            private System.Numerics.Matrix3x2 mTransform;

            //public Scene1(Game argGame) : base(argGame)
            //{
            //}

            public override void Initialize()
            {
                base.Initialize();
                mTransform = System.Numerics.Matrix3x2.CreateTranslation(10, 80);
            }

            public override void Render(GameTime argTime)
            {
                base.Render(argTime);

                var pHost = Game.Host;

                pHost.setTransform(1, 0, 0, 1, 0, 0);
                pHost.clearRect(0, 0, 300, 400);
                pHost.setfillStyle("green");
                pHost.fillRect(10, 50, 300, 100);
                pHost.setfont("16px verdana");
                //pHost.strokeText($"elapsed: {argTime.ElapsedGameTime:n2} total: {argTime.TotalGameTime:n2}", 10, 80);
                pHost.setTransform(mTransform.M11, mTransform.M12, mTransform.M21, mTransform.M22, mTransform.M31, mTransform.M32);                
                pHost.strokeText($"elapsed: {argTime.ElapsedGameTime:n2} total: {argTime.TotalGameTime:n2}", 1, 1);                
            }
        }
        //private class Test1Render : Component2d, IComponentRender
        //{
        //    public void Render(GameTime argTime)
        //    {
        //        var pHost = Owner.Scene.Game.Host;

        //        pHost.clearRect(0, 0, 300, 400);
        //        pHost.setfillStyle("green");
        //        pHost.fillRect(10, 50, 300, 100);
        //        pHost.setfont("16px verdana");
        //        pHost.strokeText($"elapsed: {argTime.ElapsedGameTime:n2} total: {argTime.TotalGameTime:n2}", 10, 80);
        //    }
        //}
        public override void Initialize()
        {
            base.Initialize();
            PresentationParameters.Width = 300;
            PresentationParameters.Height = 400;

            //PresentationParameters.MainScene = new Scene1(this);

            /*
            var pScene = new Scene(this);

            pScene.Objs.Add
            (
                new GameObject(pScene, new Test1Render())
            );
            PresentationParameters.MainScene = pScene;
            */
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