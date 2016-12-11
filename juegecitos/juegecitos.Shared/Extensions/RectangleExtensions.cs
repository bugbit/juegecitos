using System;
using Microsoft.Xna.Framework;

namespace juegecitos.Shared.Extensions
{
	public static class RectangleExtensions
	{
		public static float CalcScaleFromScreen(this Rectangle argRectScreenSource,Rectangle argRectScreenDest)
		{
			if (argRectScreenDest.Width < argRectScreenDest.Height)
				return (float)argRectScreenDest.Width / argRectScreenSource.Width;

			return (float)argRectScreenDest.Height / argRectScreenSource.Height;
		}

		public static Point CalcPositionForScreen (this Rectangle argRect,float argScale)
		{
			return new Point
			(
				(int)(argRect.X*argScale),
				(int)(argRect.Y*argScale)
			);
		}

		public static Point CalcSizeForScreen (this Rectangle argRect,float argScale)
		{
			return new Point
			(
				(int)(argRect.Width*argScale),
				(int)(argRect.Height*argScale)
			);
		}
	}
}

