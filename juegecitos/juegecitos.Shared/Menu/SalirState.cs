using System;
using Microsoft.Xna.Framework;

namespace juegecitos.Shared.Menu
{
	public class SalirState : Core.DrawableGameComponentState
	{
		public SalirState (Game argGame):base(argGame)
		{
		}

		public override void Enter (GameTime gameTime)
		{
			Game.Exit ();
			base.Enter (gameTime);
		}
	}
}

