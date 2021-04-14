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
        /*
        private GameObject mPlayer1;
        private GameObject mPlayer2;
        private GameObject mScorePlayer1;
        private GameObject mScorePlayer2;
        private GameObject mBall;
        private GameObject mNet;
        */

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
            PresentationParameters.MainScene = new PingPongScene(this);

            /*
            var pScene = new Scene(this);
            var pPlayer1 = new GameObject2d(pScene, new ScoreComponent(), new FillRectRenderComponent { FillStyle = "#FFF" })
            {
                Transform = new Transform2d { Position = new System.Numerics.Vector2(10, PresentationParameters.Height / 2 - paddleHeight / 2), Scale = new System.Numerics.Vector2(paddleWidth, paddleHeight) }
            };
            var pPlayer2 = new GameObject2d(pScene, new ScoreComponent(), new FillRectRenderComponent { FillStyle = "#FFF" })
            {
                Transform = new Transform2d { Position = new System.Numerics.Vector2(PresentationParameters.Width - (paddleWidth + 10), PresentationParameters.Height / 2 - paddleHeight / 2), Scale = new System.Numerics.Vector2(paddleWidth, paddleHeight) }
            };

            pScene.Objs.AddRange
            (
                pPlayer1,
                new GameObject2d(pScene, new ScoreRenderComponent { Score = pPlayer1.GetComponent<ScoreComponent>() })
                {
                    Transform = new Transform2d { Position = new System.Numerics.Vector2(PresentationParameters.Width / 4, PresentationParameters.Height / 6) }
                },
                new GameObject2d(pScene, new FillRectRenderComponent { FillStyle = "#FFF" })
                {
                    Transform = new Transform2d { Position = new System.Numerics.Vector2(PresentationParameters.Width / 2 - netWidth / 2, 0), Scale = new System.Numerics.Vector2(netWidth, netHeight) }
                },
                pPlayer2,
                new GameObject2d(pScene, new ScoreRenderComponent { Score = pPlayer2.GetComponent<ScoreComponent>() })
                {
                    Transform = new Transform2d { Position = new System.Numerics.Vector2(3 * PresentationParameters.Width / 4, PresentationParameters.Height / 6) }
                }
            );

            PresentationParameters.MainScene = pScene;
            */
        }
    }
}
