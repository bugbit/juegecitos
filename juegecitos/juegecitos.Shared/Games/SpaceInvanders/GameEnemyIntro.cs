using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using juegecitos.Shared.Extensions;

namespace juegecitos.Shared.Games.SpaceInvanders
{
	public class GameEnemyIntro : GameItem<EnemyDef>
	{
		private const int mSep=4;
		private Rectangle mBounds;
		private Point mPosSprite;
		private Vector2 mPosText;

		public string TextPoint { get; private set; }
		public Vector2 SizeTextPoint { get; private set; }

		public override Rectangle Bounds=>mBounds;

		public override Rectangle BoundsSprite
		{
			get
			{
				mBoundsSprite.Location=mBounds.Location+mPosSprite;

				return mBoundsSprite;
			}
		}

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
			var pX0 = ((int)SizeTextPoint.X - BoundsSprite.Width) / 2;

			mBounds.Size = pSize;// = new Rectangle (mBounds.Location, pSize);
			mPosSprite= new Point (Math.Max(pX0,0), 0);
			mPosText = new Vector2 ((pX0<0) ? -pX0 : 0, BoundsSprite.Height + mSep);
		}

		public override void Draw (SpriteBatch argSB, GameTime gameTime)
		{
			var pJuegecitosService = Game.GetService<Core.IJuegecitosService> ();

			base.Draw (argSB, gameTime);
			argSB.DrawString (pJuegecitosService.IntrsFont, TextPoint, mBounds.Location.ToVector2() + mPosText, Color.White);
		}

		public override void SetLocation (Point argPos)
		{
			mBounds.Location = argPos;
		}
	}
}

