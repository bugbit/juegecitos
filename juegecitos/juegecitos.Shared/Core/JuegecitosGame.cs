using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using juegecitos.Shared.Extensions;

namespace juegecitos.Shared
{
	/// <summary>
	/// This is the main type for your game.
	/// </summary>
	public class JuegecitosGame : Game,Core.IJuegecitosService
	{		
		GraphicsDeviceManager graphics;

		public Color BackGround { get; set; }=Color.CornflowerBlue;
		public Core.IStateManager StateManager { get; private set; }

		public JuegecitosGame ()
		{
			graphics = new GraphicsDeviceManager (this);
			Content.RootDirectory = "Content";
		}

		/// <summary>
		/// Allows the game to perform any initialization it needs to before starting to run.
		/// This is where it can query for any required services and load any non-graphic
		/// related content.  Calling base.Initialize will enumerate through any components
		/// and initialize them as well.
		/// </summary>
		protected override void Initialize ()
		{
			// TODO: Add your initialization logic here

			Components.ComponentAdded += StateManager_Added;
			this.Attach<Core.IJuegecitosService>(this);
			StateManager = new Core.StateManagerComponent(this);
			Components.Add(StateManager);
            
			base.Initialize ();
		}

		private void StateManager_Added(object sender,GameComponentCollectionEventArgs e)
		{
			Components.ComponentAdded -= StateManager_Added;
			StateManager.PushState(null, new Menu.MenuState(this), Core.Modalities.Exclusive);
		}

		/// <summary>
		/// LoadContent will be called once per game and is the place to load
		/// all of your content.
		/// </summary>
		protected override void LoadContent ()
		{						
			//TODO: use this.Content to load your game content here 
			//StateManager.PushState(null, new Menu.MenuState(this), Core.Modalities.Exclusive);
		}

		/// <summary>
		/// Allows the game to run logic such as updating the world,
		/// checking for collisions, gathering input, and playing audio.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		protected override void Update (GameTime gameTime)
		{
			

            
			// TODO: Add your update logic here
            
			base.Update (gameTime);
		}

		/// <summary>
		/// This is called when the game should draw itself.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		protected override void Draw (GameTime gameTime)
		{
			graphics.GraphicsDevice.Clear (BackGround);
            
			//TODO: Add your drawing code here
            
			base.Draw (gameTime);
		}
	}
}

