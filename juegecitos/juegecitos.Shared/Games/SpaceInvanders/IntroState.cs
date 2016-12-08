using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using juegecitos.Shared.Extensions;
using Microsoft.Xna.Framework.Input;

namespace juegecitos.Shared.Games.SpaceInvanders
{
	public class IntroState: Core.DrawableGameComponentState
	{
		private Texture2D mSplashImg;
		private Vector2 mPosSplash;

		public IntroState(Game argGame):base(argGame)
		{
		}

		protected override void LoadContent ()
		{
			var pGame = Game;

			mSplashImg = pGame.Content.Load<Texture2D> ("SpaceInvanders/splash");

			var pView = pGame.GraphicsDevice.Viewport;

			mPosSplash = new Vector2 (Math.Max((pView.Width - mSplashImg.Width) / 2,0), 0);
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
			using (var pBatch = new SpriteBatch (Game.GraphicsDevice)) {
				pBatch.Begin ();
				pBatch.Draw (mSplashImg, mPosSplash,null,new Rectangle(0,0,640,270));
				pBatch.End ();
			}
			base.Draw (gameTime);
		}

		public override void Update (GameTime gameTime)
		{
			if (GamePad.GetState (PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState ().IsKeyDown (Keys.Escape))
				Game.GetService<Core.IJuegecitosService>().StateManager.PopState(gameTime);
			base.Update (gameTime);
		}
	}
}

