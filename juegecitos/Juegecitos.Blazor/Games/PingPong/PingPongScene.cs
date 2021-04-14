using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Juegecitos.Blazor.Core;

namespace Juegecitos.Blazor.Games.PingPong
{
    public class PingPongScene : Scene
    {
        const int netWidth = 4;
        const int netHeight = 400;
        const int paddleWidth = 10;
        const int paddleHeight = 100;

        private Paddle mPlayer;

        public PingPongScene(Game argGame) : base(argGame)
        {
        }

        public override void Initialize()
        {
            base.Initialize();

            //var pHost = Game.Host;

            mPlayer = new Paddle(this)
            {
                Transform = new Transform2d { Position = new System.Numerics.Vector2(10, Game.Height / 2 - paddleHeight / 2), Scale = new System.Numerics.Vector2(paddleWidth, paddleHeight) },
                Color = "#FFF"
            };
        }

        public override void Render(GameTime argTime)
        {
            var pHost = Game.Host;

            base.Render(argTime);
            pHost.setfillStyle("#000"); /* whatever comes below this acquires black color (#000). */
            // draws the black board
            pHost.fillRect(0, 0, Game.Width, Game.Height);
            mPlayer.Render(argTime);
        }
    }
}
