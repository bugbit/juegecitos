using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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
        const float factor = 1.0f / 12.0f;

        private PaddleObj mPlayerLeft;
        private ScoreObj mScoreLeft;
        private PaddleObj mPlayerRight;
        private ScoreObj mScoreRight;
        private NetObj mNetObj;
        private BallObj mBallObj;
        private Vector2 mVectDirBallY = new Vector2(1, -1);
        private Vector2 mVectDirBallReset = new Vector2(-1, -1);

        public PingPongScene(Game argGame) : base(argGame)
        {
        }

        public override void Initialize()
        {
            base.Initialize();

            //var pHost = Game.Host;

            mPlayerLeft = new PaddleInputObj(this)
            {
                Transform = new Transform2d { Position = new Vector2(10, Game.Height / 2 - paddleHeight / 2), Scale = new Vector2(paddleWidth, paddleHeight) },
                Color = "#FFF",
                AxisName = "Vertical1"
            };
            mPlayerRight = new PaddleInputObj(this)
            {
                Transform = new Transform2d { Position = new Vector2(Game.Width - (paddleWidth + 10), Game.Height / 2 - paddleHeight / 2), Scale = new Vector2(paddleWidth, paddleHeight) },
                Color = "#FFF",
                AxisName = "Vertical2"
            };
            mScoreLeft = new ScoreObj(this)
            {
                Transform = new Transform2d { Position = new Vector2(Game.Width / 4, Game.Height / 6) },
                Paddle = mPlayerLeft
            };
            mScoreRight = new ScoreObj(this)
            {
                Transform = new Transform2d { Position = new Vector2(3 * Game.Width / 4, Game.Height / 6) },
                Paddle = mPlayerRight
            };
            mNetObj = new NetObj(this)
            {
                Transform = new Transform2d { Position = new Vector2(Game.Width / 2 - netWidth / 2, 0), Scale = new Vector2(netWidth, netHeight) }
            };
            mBallObj = new BallObj(this)
            {
                Transform = new Transform2d { Position = new Vector2(Game.Width / 2, Game.Height / 2) },
                Color = "#05EDFF",
                Radius = 7,
                Speed = 7 * factor,
                Velocity = new Vector2(5 * factor, 5 * factor)
            };
        }

        public override void Render(GameTime argTime)
        {
            var pHost = Game.Host;

            base.Render(argTime);
            pHost.setfillStyle("#000"); /* whatever comes below this acquires black color (#000). */
            // draws the black board
            pHost.fillRect(0, 0, Game.Width, Game.Height);
            mPlayerLeft.Render(argTime);
            mScoreLeft.Render(argTime);
            mPlayerRight.Render(argTime);
            mScoreRight.Render(argTime);
            mNetObj.Render(argTime);
            mBallObj.Render(argTime);
        }

        public override void Update(GameTime argTime)
        {
            base.Update(argTime);

            mPlayerLeft.Update(argTime);
            mPlayerRight.Update(argTime);
            mBallObj.Update(argTime);

            if (mBallObj.Transform.Position.Y + mBallObj.Radius >= Game.Height || mBallObj.Transform.Position.Y - mBallObj.Radius <= 0)
                mBallObj.Velocity *= mVectDirBallY;
            else if (mBallObj.Transform.Position.X + mBallObj.Radius >= Game.Width)
            {
                mPlayerLeft.Score++;
                Reset();
            }
            else if (mBallObj.Transform.Position.X - mBallObj.Radius <= 0)
            {
                mPlayerRight.Score++;
                Reset();
            }
            else
            {
                CollisionPlayerBall(mPlayerRight, mBallObj, true);
                CollisionPlayerBall(mPlayerLeft, mBallObj, false);
            }
        }

        private void Reset()
        {
            mBallObj.Transform.Position = new Vector2(Game.Width / 2, Game.Height / 2);
            mBallObj.Speed = 7 * factor;
            mBallObj.Velocity *= mVectDirBallReset;
        }

        private bool CollisionPlayerBall(PaddleObj argPlayerObj, BallObj argBallObj, bool argPlayerRight)
        {
            var pBallY = argBallObj.Transform.Position.Y;
            var pPlayerY = argPlayerObj.Transform.Position.Y;

            if
            (
                argPlayerObj.Transform.Position.X <= argBallObj.Transform.Position.X && argPlayerObj.Transform.Position.X + argPlayerObj.Transform.Scale.X >= argBallObj.Transform.Position.X
                && pPlayerY <= pBallY && pPlayerY + argPlayerObj.Transform.Scale.Y >= pBallY
            )
            {
                var pAng = 0.0f;
                var pDir = (argPlayerRight) ? -1.0f : 1.0f;
                var pRad_2 = argBallObj.Radius / 2.0f;
                var pY_2 = pPlayerY / 2.0f;

                if (pBallY < pY_2 - pRad_2)
                    pAng = MathF.PI / -4.0f;
                else if (pBallY > pY_2 + pRad_2)
                    pAng = MathF.PI / 4.0f;

                argBallObj.Velocity = pDir * argBallObj.Speed * new Vector2(MathF.Cos(pAng), MathF.Sin(pAng));

                return true;
            }

            return false;
        }
    }
}
