using System;

namespace juegecitos.Shared.Core
{
	public class SpriteGameComponentCollectionEventArgs
	{
		public ISpriteGameComponent SpriteGameComponent { get; private set;}

		public SpriteGameComponentCollectionEventArgs (ISpriteGameComponent argSpriteGameComponent)
		{
			SpriteGameComponent = argSpriteGameComponent;
		}
	}
}

