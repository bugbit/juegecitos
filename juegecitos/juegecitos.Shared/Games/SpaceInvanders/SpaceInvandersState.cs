using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using juegecitos.Shared.Extensions;

namespace juegecitos.Shared.Games.SpaceInvanders
{
	public class SpaceInvandersState: Core.DrawableGameComponentState,IService
	{
		public SpaceInvandersState(Game argGame):base(argGame)
		{
		}

		public override void Initialize ()
		{
			var pGame = Game;

			pGame.Attach<IService>(this);
			base.Initialize ();
		}

		protected override void LoadContent ()
		{
			base.LoadContent ();
		}

		protected override void UnloadContent ()
		{
			base.UnloadContent ();
		}

		protected override void Dispose (bool disposing)
		{
			Game.DeAttach<IService> ();
			base.Dispose (disposing);
		}

		public override void Enter (GameTime gameTime)
		{
			Game.GetService<Core.IJuegecitosService>().StateManager.PushState(gameTime,new IntroState(Game),Core.Modalities.Exclusive);
			base.Enter (gameTime);
		}

		public override void Update (GameTime gameTime)
		{
//			if (GamePad.GetState (PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState ().IsKeyDown (Keys.Escape))
//				Game.GetService<Core.IJuegecitosService>().StateManager.PopState(gameTime);
			base.Update (gameTime);
		}
	}
}

