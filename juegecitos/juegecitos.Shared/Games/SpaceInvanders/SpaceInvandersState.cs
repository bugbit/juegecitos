using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using juegecitos.Shared.Extensions;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace juegecitos.Shared.Games.SpaceInvanders
{
	public class SpaceInvandersState: Core.DrawableGameComponentState,IService
	{
		public Strings Strs { get; private set; }
		public Texture2D Sprites{ get; private set; }
		public IDictionary<Enemies,EnemyDef> EnemiesDefs{ get; private set; }

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
			var pContent = Game.Content;

			Sprites = pContent.Load<Texture2D>("SpaceInvanders/sprites");
			Strs = pContent.LoadStrings<Strings>("SpaceInvanders/Strings");
			EnemiesDefs = pContent.LoadDict<Enemies,EnemyDef> ("SpaceInvanders/EnemyDef", e=>e.Enemy);

			//var p = Game.Content.LoadSprites<Sprites> ("SpaceInvanders/MapSprites");



			base.LoadContent ();
		}

		protected override void UnloadContent ()
		{
			Game.DeAttach<IService> ();
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

		public override void Obscure (GameTime gameTime)
		{
			Game.GetService<Core.IJuegecitosService>().StateManager.PopState(gameTime);
			base.Obscure (gameTime);
		}

		public override void Update (GameTime gameTime)
		{
//			if (GamePad.GetState (PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState ().IsKeyDown (Keys.Escape))
//				Game.GetService<Core.IJuegecitosService>().StateManager.PopState(gameTime);
			base.Update (gameTime);
		}
	}
}

