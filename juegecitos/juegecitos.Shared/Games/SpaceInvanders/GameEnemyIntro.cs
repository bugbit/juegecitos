using System;
using Microsoft.Xna.Framework;
using juegecitos.Shared.Extensions;

namespace juegecitos.Shared.Games.SpaceInvanders
{
	public class GameEnemyIntro : GameItem<EnemyDef>
	{
		private const int mSep=4;
		private Rectangle mBounds;

		public string TextPoint { get; private set; }
		public Vector2 SizeTextPoint { get; private set; }

		public override Rectangle Bounds=>mBounds;

		public GameEnemyIntro(Game argGame):base(argGame)
		{
		}

		public override void Initialize ()
		{
			var pJuegecitosService = Game.GetService<Core.IJuegecitosService> ();

			TextPoint = $"{ItemDef.Points} Pts";
			SizeTextPoint = pJuegecitosService.IntrsFont.MeasureString (TextPoint);
			base.Initialize ();

			var pSize = new Point (Math.Max (BoundsSprite.Width, (int)SizeTextPoint.X), BoundsSprite.Height + mSep + (int)SizeTextPoint.Y);

			mBounds.Size = pSize;// = new Rectangle (mBounds.Location, pSize);
		}

		public override void Draw (Microsoft.Xna.Framework.Graphics.SpriteBatch argSB, GameTime gameTime)
		{
			base.Draw (argSB, gameTime);
		}
	}
}

