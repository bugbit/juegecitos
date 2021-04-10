using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Juegecitos.Blazor.Core;
using Juegecitos.Blazor.Core.Components;

namespace Juegecitos.Blazor.Games.PingPong
{
    public class PingPongGame : Game
    {
        private GameObject mPlayer1;
        private GameObject mPlayer2;
        private GameObject mScorePlayer1;
        private GameObject mScorePlayer2;
        private GameObject mBall;
        private GameObject mNet;

        public override void Initialize()
        {
            const int netWidth = 4;
            const int netHeight = 400;
            const int paddleWidth = 10;
            const int paddleHeight = 100;

            base.Initialize();
            PresentationParameters.BackColor = "white";
            PresentationParameters.Width = 600;
            PresentationParameters.Height = 400;
            mPlayer1 = new GameObject(this);
            mPlayer2 = new GameObject(this);
            mScorePlayer1 = new GameObject(this);
            mScorePlayer2 = new GameObject(this);
            mBall = new GameObject(this);
            mNet = new GameObject(this);

            var pScore1 = mPlayer1.AddComponent(new ScoreComponent());
            var pScore2 = mPlayer2.AddComponent(new ScoreComponent());

            mPlayer1.AddComponents
            (
                new Transform2d { Position = new System.Numerics.Vector2(10, PresentationParameters.Height / 2 - paddleHeight / 2), Scale = new System.Numerics.Vector2(paddleWidth, paddleHeight) },
                new FillRectRenderComponent { FillStyle = "#FFF" }
            );
            mPlayer2.AddComponents
            (
                new Transform2d { Position = new System.Numerics.Vector2(PresentationParameters.Width - (paddleWidth + 10), PresentationParameters.Height / 2 - paddleHeight / 2), Scale = new System.Numerics.Vector2(paddleWidth, paddleHeight) },
                new FillRectRenderComponent { FillStyle = "#FFF" }
            );

            mScorePlayer1.AddComponents(new Transform2d { Position = new System.Numerics.Vector2(PresentationParameters.Width / 4, PresentationParameters.Height / 6) }, pScore1, new ScoreRenderComponent());
            mScorePlayer2.AddComponents(new Transform2d { Position = new System.Numerics.Vector2(3 * PresentationParameters.Width / 4, PresentationParameters.Height / 6) }, pScore2, new ScoreRenderComponent());
            mNet.AddComponents
            (
                new Transform2d { Position = new System.Numerics.Vector2(PresentationParameters.Width / 2 - netWidth / 2, 0), Scale = new System.Numerics.Vector2(netWidth, netHeight) },
                new FillRectRenderComponent { FillStyle = "#FFF" }
            );
        }

        public override void Render(GameTime argTime)
        {
            base.Render(argTime);
            Host.setfillStyle("#000");
            Host.fillRect(0, 0, 600, 400);
            mPlayer1.Render(argTime);
            mPlayer2.Render(argTime);
            mScorePlayer1.Render(argTime);
            mScorePlayer2.Render(argTime);
            mBall.Render(argTime);
            mNet.Render(argTime);
        }

        public override void Update(GameTime argTime)
        {
            base.Update(argTime);
            mPlayer1.Update(argTime);
            mPlayer2.Update(argTime);
            mScorePlayer1.Update(argTime);
            mScorePlayer2.Update(argTime);
            mBall.Update(argTime);
            mNet.Update(argTime);
        }
    }
}
