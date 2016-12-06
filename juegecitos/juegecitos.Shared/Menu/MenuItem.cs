using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace juegecitos.Shared.Menu
{
	public class MenuItem
	{
		public string Image{ get; set; }
		public string TypeGameComponent{ get; set; }
		internal Texture2D Texture{ get; set; }
	}
}

