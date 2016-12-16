using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using juegecitos.Shared.Extensions;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using FP=FarseerPhysics;

namespace juegecitos.Shared.Games.SpaceInvanders
{
	public class SpaceInvandersState: Core.DrawableGameComponentState,IService
	{
		public float Scale { get; set; }
		public Strings Strs { get; private set; }
		public Texture2D Sprites{ get; private set; }
		public Core.MapSprites<Sprites> MapSprites { get; private set; }
		public IDictionary<Items,EnemyDef> EnemiesDefs{ get; private set; }
		public FP.Dynamics.World FPWorld { get; private set; }

		public SpaceInvandersState(Game argGame):base(argGame)
		{
		}

		public override void Initialize ()
		{
			var pGame = Game;

			pGame.Attach<IService>(this);
			Scale = new Rectangle (0, 0, 640, 400).CalcScaleFromScreen (GraphicsDevice.Viewport.Bounds);
			FPWorld = new FP.Dynamics.World (new Vector2 (0, 9.8f));
			base.Initialize ();
		}

		protected override void LoadContent ()
		{
			var pContent = Game.Content;

			Sprites = pContent.Load<Texture2D>("SpaceInvanders/sprites");
			MapSprites=pContent.LoadSprites<Sprites> ("SpaceInvanders/MapSprites");
			Strs = pContent.LoadStrings<Strings>("SpaceInvanders/Strings");
			EnemiesDefs = pContent.LoadDict<Items,EnemyDef> ("SpaceInvanders/EnemyDef", e=>e.ItemType);

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

		public override void Exit (GameTime gameTime)
		{
			Game.DeAttach<IService> ();
			base.Exit (gameTime);
		}

		public override void Reveal (GameTime gameTime)
		{
			Game.GetService<Core.IJuegecitosService>().StateManager.PopState(gameTime);
			base.Reveal (gameTime);
		}

		public override void Update (GameTime gameTime)
		{
			FPWorld.Step(Math.Min((float)gameTime.ElapsedGameTime.TotalMilliseconds * 0.001f, (1f / 30f)));
//			if (GamePad.GetState (PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState ().IsKeyDown (Keys.Escape))
//				Game.GetService<Core.IJuegecitosService>().StateManager.PopState(gameTime);
			base.Update (gameTime);
		}
	}
}

