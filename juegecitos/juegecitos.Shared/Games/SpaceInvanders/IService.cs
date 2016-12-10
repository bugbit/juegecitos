using System;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace juegecitos.Shared.Games.SpaceInvanders
{
	public interface IService
	{
		Strings Strs { get; }
		Texture2D Sprites{ get; }
		IDictionary<Enemies,EnemyDef> EnemiesDefs{ get; }
	}
}

