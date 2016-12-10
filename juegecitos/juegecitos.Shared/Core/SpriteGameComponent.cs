using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace juegecitos.Shared.Core
{
	public class SpriteGameComponent: IGameComponent,ISpriteGameComponent, IDisposable
	{
		private bool mInitialized;
		private bool mEnabled = true;
		private bool mVisible = true;

		public Game Game { get; private set; }

		public GraphicsDevice GraphicsDevice
		{
			get { return this.Game.GraphicsDevice; } 
		}

		public bool Enabled
		{
			get { return mEnabled; }
			set
			{
				if (mEnabled != value)
				{
					mEnabled = value;
					if (this.EnabledChanged != null)
						this.EnabledChanged(this, EventArgs.Empty);
					OnEnabledChanged(this, null);
				}
			}
		}

		public bool Visible
		{
			get { return mVisible; }
			set
			{
				if (mVisible != value)
				{
					mVisible = value;
					if (VisibleChanged != null)
						VisibleChanged(this, EventArgs.Empty);
					OnVisibleChanged(this, EventArgs.Empty);
				}
			}
		}

		public event EventHandler<EventArgs> EnabledChanged;
		public event EventHandler<EventArgs> VisibleChanged;

		public SpriteGameComponent(Game game)
		{
			this.Game = game;
		}

		~SpriteGameComponent()
		{
			Dispose(false);
		}

		public virtual void Initialize(){
			if (!mInitialized)
			{
				mInitialized = true;
				LoadContent();
			}
		}

		public virtual void Update(GameTime gameTime) { }

		protected virtual void LoadContent() { }

		protected virtual void UnloadContent () { }

		public virtual void Draw(SpriteBatch argSB,GameTime gameTime) { }

		protected virtual void OnEnabledChanged(object sender, EventArgs e) { }
		protected virtual void OnVisibleChanged(object sender, EventArgs e) { }
		/// <summary>
		/// Shuts down the component.
		/// </summary>
		protected virtual void Dispose(bool disposing) { }

		/// <summary>
		/// Shuts down the component.
		/// </summary>
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
	}
}

