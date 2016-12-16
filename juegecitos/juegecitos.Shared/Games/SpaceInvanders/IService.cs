using System;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using FP=FarseerPhysics;

namespace juegecitos.Shared.Games.SpaceInvanders
{
	public interface IService
	{
		float Scale { get; set; }
		Strings Strs { get; }
		Texture2D Sprites{ get; }
		Core.MapSprites<Sprites> MapSprites { get; }
		IDictionary<Items,EnemyDef> EnemiesDefs{ get; }
		FP.Dynamics.World FPWorld { get; }
	}
}

