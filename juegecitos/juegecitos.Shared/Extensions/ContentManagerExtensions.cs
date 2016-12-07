using System;
using Microsoft.Xna.Framework.Content;

namespace juegecitos.Shared.Extensions
{
	public static class ContentManagerExtensions
	{
		public static T LoadStrings<T>(this ContentManager argContent,string argAssetName)
		{
			var pStrings=argContent.Load<T>(argAssetName);

			return pStrings;
		}
	}
}

