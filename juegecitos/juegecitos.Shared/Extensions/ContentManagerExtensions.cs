using System;
using Microsoft.Xna.Framework.Content;
using System.Collections.Generic;

namespace juegecitos.Shared.Extensions
{
	public static class ContentManagerExtensions
	{
		public static T LoadStrings<T>(this ContentManager argContent,string argAssetName)
		{
			var pStrings=argContent.Load<T>(argAssetName);

			return pStrings;
		}

		public static Core.MapSprites<E> LoadSprites<E>(this ContentManager argContent,string argAssetName)
		{
			var pAsset = argContent.Load<Core.MapSprite[]> (argAssetName);
			var pMap = new Core.MapSprites<E> (pAsset);

			return pMap;
		}

		public static IDictionary<K,T> LoadDict<K,T>(this ContentManager argContent,string argAssetName,Func<T,K> argKey)
		{
			var pAsset = argContent.Load<T[]> (argAssetName);
			var pDict = new Dictionary<K,T> ();

			foreach (var pItem in pAsset)
				pDict.Add (argKey.Invoke (pItem), pItem);

			return pDict;
		}
	}
}

