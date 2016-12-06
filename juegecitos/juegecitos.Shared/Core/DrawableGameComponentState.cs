using System;
using Microsoft.Xna.Framework;

namespace juegecitos.Shared.Core
{
	public class DrawableGameComponentState: DrawableGameComponent, IState
	{
		public DrawableGameComponentState(Game argGame) : base(argGame)
		{			
		}

		virtual public void Enter(GameTime gameTime)
		{
			LoadContent ();
		}

		virtual public void Exit(GameTime gameTime)
		{
			UnloadContent ();
		}

		virtual public void Obscure(GameTime gameTime)
		{
		}

		virtual public void Reveal(GameTime gameTime)
		{
		}
	}
}
