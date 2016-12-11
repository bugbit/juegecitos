using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using juegecitos.Shared.Extensions;

namespace juegecitos.Shared.Games.SpaceInvanders
{
	public class GameItem<T> : Core.SpriteGameComponent where T:ItemDef
	{
		private int? mIdx;
		private Rectangle mRectSource;
		protected Rectangle mBoundsSprite;
		private int mEllapseCambioSprite;

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

			if (mIdx.HasValue)
				argSB.Draw (pService.Sprites, null, BoundsSprite,mRectSource);
			base.Draw (argSB, gameTime);
		}

		public override void Update (GameTime gameTime)
		{
			var pOldIdx = mIdx;

			if (!mIdx.HasValue) {
				mIdx = 0;
				mEllapseCambioSprite = 0;
			}
			if (mEllapseCambioSprite > 500) {
				mIdx = (mIdx + 1) % ItemDef.Sprites.Length;
				mEllapseCambioSprite = mEllapseCambioSprite % 500;
			} else
				mEllapseCambioSprite += gameTime.ElapsedGameTime.Milliseconds;
			if (pOldIdx != mIdx) {
				var pService = Game.GetService<IService> ();

				mRectSource = pService.MapSprites [ItemDef.Sprites [mIdx.Value]];
			}	
			base.Update (gameTime);
		}

		public void CalcSizeSprite ()
		{
			var pService = Game.GetService<IService> ();
			var pSize= mRectSource.CalcSizeForScreen (pService.Scale);

			mBoundsSprite.Size = pSize;
		}
	}
}

