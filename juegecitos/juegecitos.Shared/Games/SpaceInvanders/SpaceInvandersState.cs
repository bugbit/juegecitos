using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace juegecitos.Shared.Games.SpaceInvanders
{
	public class SpaceInvandersState: Core.DrawableGameComponentState
	{
		public SpaceInvandersState(Game argGame):base(argGame)
		{
		}

		public override void Update (GameTime gameTime)
		{
			if (GamePad.GetState (PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState ().IsKeyDown (Keys.Escape))
				Game.Services.GetService<Core.IJuegecitosService> ().StateManager.PopState(gameTime);
			base.Update (gameTime);
		}
	}
}

