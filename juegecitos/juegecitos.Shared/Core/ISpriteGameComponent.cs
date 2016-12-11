using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace juegecitos.Shared.Core
{
	public interface ISpriteGameComponent
	{
		bool Enabled { get; }
		bool Visible { get; }

		event EventHandler<EventArgs> EnabledChanged;
		event EventHandler<EventArgs> VisibleChanged;

		void Initialize ();
		void Update(GameTime gameTime);
		void Draw(SpriteBatch argSB,GameTime gameTime);  
	}
}

