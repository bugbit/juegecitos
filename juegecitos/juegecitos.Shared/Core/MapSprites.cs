using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace juegecitos.Shared.Core
{
	public class MapSprites<E> : Dictionary<E,Rectangle>
	{
		public MapSprites():base(){
		}

		public MapSprites(MapSprite[] argSprites)
		{
			foreach (var pSprite in argSprites) {
				var pE= (E)Enum.Parse (typeof(E), pSprite.Id);

				Add (pE, new Rectangle (pSprite.X, pSprite.Y, pSprite.Width, pSprite.Height));
			}
		}
	}
}

