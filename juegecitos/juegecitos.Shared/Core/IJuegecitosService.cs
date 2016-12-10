using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace juegecitos.Shared.Core
{
	public interface IJuegecitosService
	{
		Color BackGround { get; set; }
		IStateManager StateManager { get; }
		SpriteFont IntrsFont { get;}
	}
}

