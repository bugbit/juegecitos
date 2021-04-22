using Juegecitos.Blazor.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace Juegecitos.Blazor.Games.PingPong
{
    public class BallObj : GameObject2d, IUpdate, IRender
    {
        public BallObj(Scene argScene) : base(argScene)
        {
        }

        public string Color { get; set; }
        public float Radius { get; set; }
        public Vector2 Velocity { get; set; }
        public float Speed { get; set; }

        public void Update(GameTime argTime)
        {
            Transform.Position += Speed * argTime.ElapsedGameTime * Velocity;
        }

        public void Render(GameTime argTime)
        {
            var pHost = Scene.Game.Host;

            pHost.setfillStyle(Color);
            pHost.beginPath();
            // syntax --> arc(x, y, radius, startAngle, endAngle, antiClockwise_or_not)
            pHost.arc((int)Transform.Position.X, (int)Transform.Position.Y, Radius, 0, Math.PI * 2, true); // π * 2 Radians = 360 degrees
            pHost.closePath();
            pHost.fill();
        }
    }
}
