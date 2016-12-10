using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace juegecitos.Shared.Extensions
{
	public static class SpriteFontExtensions
	{
		public static Vector2[] MeasureString(this SpriteFont argSF, string[] argStrs)
		{
			var pDims = new Vector2[argStrs.Length];

			for (var i = 0; i <= argStrs.Length; i++)
				pDims [i] = argSF.MeasureString (argStrs [i]);

			return pDims;
		}
	}
}

