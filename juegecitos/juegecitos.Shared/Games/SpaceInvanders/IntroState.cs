using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using juegecitos.Shared.Extensions;
using Microsoft.Xna.Framework.Input;

namespace juegecitos.Shared.Games.SpaceInvanders
{
	public class IntroState: Core.DrawableGameComponentState
	{
		private const int mSpaceLinesIntrs = 4;

		private Texture2D mSplashImg;
		private Vector2 mPosSplash;
		private Tuple<Vector2,string>[] mIntrs;

		public IntroState(Game argGame):base(argGame)
		{
		}

		protected override void LoadContent ()
		{
			var pGame = Game;
			var pView = pGame.GraphicsDevice.Viewport;
			var pService = pGame.GetService<IService> ();
			var pJService = pGame.GetService<Core.IJuegecitosService> ();
			var pIntrs = pService.Strs.Intrs;

			mSplashImg = pGame.Content.Load<Texture2D> ("SpaceInvanders/splash");
			mPosSplash = new Vector2 (Math.Max((pView.Width - mSplashImg.Width) / 2,0), 0);
			mIntrs = new Tuple<Vector2, string>[pIntrs.Length];

			var pY=(float)pView.Height;

			for (var i = pIntrs.Length - 1; i >= 0; i--) {
				var pStr = pIntrs [i];
				var pDim = pJService.IntrsFont.MeasureString (pStr);

				pY -= pDim.Y + mSpaceLinesIntrs;
				mIntrs [i] = new Tuple<Vector2, string> (new Vector2 ((pView.Width - pDim.X) / 2, pY), pStr);
			}
			base.LoadContent ();
		}

		protected override void UnloadContent ()
		{
			mSplashImg?.Dispose ();
			base.UnloadContent ();
		}

		public override void Enter (GameTime gameTime)
		{
			Game.GetService<Core.IJuegecitosService> ().BackGround = Color.Blue;
			base.Enter (gameTime);
		}

		public override void Draw (Microsoft.Xna.Framework.GameTime gameTime)
		{
			var pGame = Game;
			var pIntrFont = Game.GetService<Core.IJuegecitosService> ().IntrsFont;

			using (var pBatch = new SpriteBatch (pGame.GraphicsDevice)) {
				pBatch.Begin ();
				pBatch.Draw (mSplashImg, mPosSplash,null,new Rectangle(0,0,640,270));
				foreach (var pIntr in mIntrs)
					pBatch.DrawString (pIntrFont, pIntr.Item2, pIntr.Item1, Color.White);
				pBatch.End ();
			}
			base.Draw (gameTime);
		}

		public override void Update (GameTime gameTime)
		{
			if (GamePad.GetState (PlayerIndex.One).Buttons.B == ButtonState.Pressed || Keyboard.GetState ().IsKeyDown (Keys.Space))
				Game.GetService<Core.IJuegecitosService>().StateManager.PopState(gameTime);
			base.Update (gameTime);
		}
	}
}

