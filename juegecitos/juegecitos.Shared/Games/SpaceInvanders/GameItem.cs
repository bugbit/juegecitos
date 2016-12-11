using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using juegecitos.Shared.Extensions;

namespace juegecitos.Shared.Games.SpaceInvanders
{
	public class GameItem<T> : Core.SpriteGameComponent where T:ItemDef
	{
		private int mIdx=0;
		private Rectangle mRectSource;
		protected Rectangle mBoundsSprite;
		private int mEllapseCambioSprite=0;

		public T ItemDef { get; set; }
		virtual public Rectangle BoundsSprite=>mBoundsSprite;
		virtual public Rectangle Bounds => mBoundsSprite;

		public GameItem(Game argGame):base(argGame)
		{
		}

		public override void Initialize ()
		{
			CalcSizeSprite ();
			base.Initialize ();
		}

		public override void Draw (SpriteBatch argSB, GameTime gameTime)
		{
			var pService = Game.GetService<IService> ();

			argSB.Draw (pService.Sprites, null, BoundsSprite,mRectSource);
			base.Draw (argSB, gameTime);
		}

		public override void Update (GameTime gameTime)
		{
			var pOldIdx = mIdx;

			if (mEllapseCambioSprite > 500) {
				mIdx = (mIdx + 1) % ItemDef.Sprites.Length;
				mEllapseCambioSprite = mEllapseCambioSprite % 500;
			} else
				mEllapseCambioSprite += gameTime.ElapsedGameTime.Milliseconds;
			if (pOldIdx != mIdx) {
				CalcSizeSourceSprite();
			}	
			base.Update (gameTime);
		}

		public void CalcSizeSourceSprite()
		{
			var pService = Game.GetService<IService> ();

			mRectSource = pService.MapSprites [ItemDef.Sprites [mIdx]];
		}

		public void CalcSizeSprite ()
		{
			var pService = Game.GetService<IService> ();

			mIdx=0;
			CalcSizeSourceSprite();

			var pSize= mRectSource.CalcSizeForScreen (pService.Scale);

			mBoundsSprite.Size = pSize;
		}

		virtual public void SetLocation(Point argPos)
		{
			mBoundsSprite.Location=argPos;
		}
	}
}

