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

        private PaddleObj mPlayer1;
        private ScoreObj mScore1;
        private PaddleObj mPlayer2;
        private ScoreObj mScore2;
        private NetObj mNetObj;

        public PingPongScene(Game argGame) : base(argGame)
        {
        }

        public override void Initialize()
        {
            base.Initialize();

            //var pHost = Game.Host;

            mPlayer1 = new PaddleObj(this)
            {
                Transform = new Transform2d { Position = new System.Numerics.Vector2(10, Game.Height / 2 - paddleHeight / 2), Scale = new System.Numerics.Vector2(paddleWidth, paddleHeight) },
                Color = "#FFF"
            };
            mScore1 = new ScoreObj(this)
            {
                Transform = new Transform2d { Position = new System.Numerics.Vector2(Game.Width / 4, Game.Height / 6) },
                Paddle = mPlayer1
            };
            mPlayer2 = new PaddleObj(this)
            {
                Transform = new Transform2d { Position = new System.Numerics.Vector2(Game.Width - (paddleWidth + 10), Game.Height / 2 - paddleHeight / 2), Scale = new System.Numerics.Vector2(paddleWidth, paddleHeight) },
                Color = "#FFF"
            };
            mScore2 = new ScoreObj(this)
            {
                Transform = new Transform2d { Position = new System.Numerics.Vector2(3 * Game.Width / 4, Game.Height / 6) },
                Paddle = mPlayer2
            };
            mNetObj = new NetObj(this)
            {
                Transform = new Transform2d { Position = new System.Numerics.Vector2(Game.Width / 2 - netWidth / 2, 0), Scale = new System.Numerics.Vector2(netWidth, netHeight) }
            };
        }

        public override void Render(GameTime argTime)
        {
            var pHost = Game.Host;

            base.Render(argTime);
            pHost.setfillStyle("#000"); /* whatever comes below this acquires black color (#000). */
            // draws the black board
            pHost.fillRect(0, 0, Game.Width, Game.Height);
            mPlayer1.Render(argTime);
            mScore1.Render(argTime);
            mPlayer2.Render(argTime);
            mScore2.Render(argTime);
            mNetObj.Render(argTime);
        }
    }
}
