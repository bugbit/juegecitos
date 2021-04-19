using Juegecitos.Blazor.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juegecitos.Blazor.Games.PingPong
{
    public class PaddleInputObj : PaddleObj
    {
        public string AxisName { get; set; }

        public PaddleInputObj(Scene argScene) : base(argScene)
        {
        }

        protected override void UpdateActions(GameTime argTime)
        {
            var pVector = Scene.Game.Actions.GetAxis(AxisName) * argTime.ElapsedGameTime / 5.0f;

            Transform.Position += pVector;
            if (Transform.Position.Y < 0)
                Transform.Position = new System.Numerics.Vector2(Transform.Position.X, 0);
            else if (Transform.Position.Y + Transform.Scale.Y > Scene.Game.Height)
                Transform.Position -= new System.Numerics.Vector2(0, (Transform.Position.Y + Transform.Scale.Y) - Scene.Game.Height);
        }
    }
}
