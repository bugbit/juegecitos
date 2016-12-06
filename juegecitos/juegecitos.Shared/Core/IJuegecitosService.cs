using System;

namespace juegecitos.Shared.Core
{
	public interface IJuegecitosService
	{
		IStateManager StateManager { get; }
	}
}

