using System;
using Microsoft.Xna.Framework;

namespace juegecitos.Shared.Core
{
	public interface IJuegecitosService
	{
		Color BackGround { get; set; }
		IStateManager StateManager { get; }
	}
}

