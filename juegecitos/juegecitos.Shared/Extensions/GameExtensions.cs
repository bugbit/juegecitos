using System;
using Microsoft.Xna.Framework;

namespace juegecitos.Shared.Extensions
{
	public static class GameExtensions
	{
		public static void Attach<T>(this Game argGame,T argService) where T : class
		{
			argGame.Services.AddService(argService);

			var pComponent=argService as IGameComponent;

			if (pComponent!=null && !(argService is Core.IState))
				argGame.Components.Add(pComponent);
		}

		public static T GetService<T>(this Game argGame) where T : class
		{
			return argGame.Services.GetService<T> ();
		}

		public static void DeAttach<T>(this Game argGame) where T : class
		{
			var pService = argGame.GetService<T> ();
			var pComponent=pService as IGameComponent;

			argGame.Services.RemoveService(typeof(T));
			if (pComponent!=null)
				argGame.Components.Remove(pComponent);
		}
	}
}

