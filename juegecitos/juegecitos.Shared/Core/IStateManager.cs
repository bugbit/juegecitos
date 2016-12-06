using System;
using Microsoft.Xna.Framework;

namespace juegecitos.Shared.Core
{
	public interface IStateManager : IGameComponent
	{
		IState StateAct { get; }
		void ChangeState(GameTime gameTime, IState argState, Modalities argModality);
		void PushState(GameTime gameTime, IState argState, Modalities argModality);
		IState PopState(GameTime gameTime);
	}
}

