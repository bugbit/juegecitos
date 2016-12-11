using System;
using Microsoft.Xna.Framework;

namespace juegecitos.Shared.Extensions
{
	public static class PointExtensions
	{
		public static Vector2 ToVector2(this Point argPoint)
		{
			return new Vector2 (argPoint.X, argPoint.Y);
				
		}
	}
}

