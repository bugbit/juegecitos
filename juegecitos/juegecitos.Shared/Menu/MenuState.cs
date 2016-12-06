using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace juegecitos.Shared.Menu
{
	public class MenuState : Core.DrawableGameComponentState
	{
		private const string cTitle = "Juegecitos";
		private SpriteFont mFont;
		private MenuItem[] mItems;
		private Vector2 mPointTitle;
		private int mYImg0;
		private Point mMaxSizeItem;
		private Point mMaxItems;
		private Point mPositionIni;
		private int mIdx0;
		private MenuItem[] mItemsAct;
		private int? mIdxSel;

		public MenuState (Game argGame):base(argGame)
		{
		}

		public override void Initialize ()
		{
			mIdx0 = 0;
			base.Initialize ();
		}

		protected override void LoadContent ()
		{
			mFont = Game.Content.Load<SpriteFont> ("Menu/font");

			var pTitle = mFont.MeasureString (cTitle);
			var pItems=Game.Content.Load<MenuItem[]> ("Menu/menus");

			mPointTitle = new Vector2 ((Game.GraphicsDevice.Viewport.Width - pTitle.X) / 2.0f, 0);
			mYImg0 = (int)pTitle.Y + 10;
			LoadImages (pItems);
			mItems = mItemsAct = pItems;
			base.LoadContent ();
		}

		protected override void UnloadContent ()
		{
			foreach (var pItem in mItems)
				pItem?.Texture?.Dispose ();
			
			base.UnloadContent ();
		}

		private void LoadImages(MenuItem[] argItems)
		{
			var pMaxSize = new Point ();
			var pGame = Game;

			LoadImages (argItems, ref pMaxSize);

			var pView = pGame.GraphicsDevice.Viewport;
			int pRemW;
			var pMaxW = Math.DivRem (pView.Width, pMaxSize.X, out pRemW);
			int pRemH;
			var pMaxH = Math.DivRem (pView.Height, pMaxSize.Y-mYImg0, out pRemH);

			mMaxSizeItem = pMaxSize;
			mMaxItems = new Point (pMaxW, pMaxH);
			mPositionIni = new Point (pRemW / 2,mYImg0+( pRemH / 2));
		}

		private void LoadImages(MenuItem[] argItems,ref Point argMaxSize)
		{
			var pGame = Game;

			foreach (var pItem in argItems) {
				pItem.Texture = pGame.Content.Load<Texture2D> ("Menu/" + pItem.Image);
				var pSize = new Point (pItem.Texture.Width + 4, pItem.Texture.Height + 4);
				if (pSize.X > argMaxSize.X)
					argMaxSize.X = pSize.X;
				if (pSize.Y > argMaxSize.Y)
					argMaxSize.Y = pSize.Y;
			}
		}

		public override void Enter (GameTime gameTime)
		{
			mIdxSel = null;
			LoadContent ();
			Game.IsMouseVisible = true;
			base.Enter (gameTime);
		}

		public override void Draw (GameTime gameTime)
		{
			using (var pBatch = new SpriteBatch (Game.GraphicsDevice)) {				
				var pPosition = new Vector2( mPositionIni.X,mPositionIni.Y);
				var pIdxP = new Point (0, 0);

				pBatch.Begin ();
				pBatch.DrawString (mFont, cTitle, mPointTitle, Color.White);
				for (int i = mIdx0; i < mItemsAct.Length; i++) {
					var pItem = mItemsAct [i];

					pBatch.Draw (pItem.Texture, pPosition,(mIdxSel.HasValue && mIdxSel.Value==i) ? Color.Red : Color.White);
					pPosition.X += mMaxSizeItem.X;
					if (++pIdxP.X >= mMaxItems.X) {
						pIdxP.X = 0;
						pPosition.X = mPositionIni.X;
						pPosition.Y += mMaxSizeItem.Y;
						if (++pIdxP.Y >= mMaxItems.Y)
							break;
					}
				}
				pBatch.End ();
			}
			base.Draw (gameTime);
		}

		public override void Update (GameTime gameTime)
		{
			var pMouseState = Mouse.GetState ();
			var pPosition = pMouseState.Position;

			// For Mobile devices, this logic will close the Game when the Back button is pressed
			// Exit() is obsolete on iOS
//			#if !__IOS__ &&  !__TVOS__
//			if (GamePad.GetState (PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState ().IsKeyDown (Keys.Escape))
//				Game.Exit ();
//			#endif
			mIdxSel = CalcIdxFromPoint(pPosition);
			if (mIdxSel.HasValue && pMouseState.LeftButton == ButtonState.Pressed) {
				var pType = Type.GetType (mItemsAct [mIdxSel.Value].TypeGameComponent);
				var pValue = pType.GetConstructor (new Type[]{typeof(Game)}).Invoke (new object[]{Game});
				var pState = pValue as Core.IState;

				Game.Services.GetService<Core.IJuegecitosService> ().StateManager.PushState (gameTime, pState, Core.Modalities.Exclusive);
			}

			base.Update (gameTime);
		}

		public override void Obscure (GameTime gameTime)
		{
			Game.IsMouseVisible = false;
			base.Obscure (gameTime);
		}

		public override void Reveal (GameTime gameTime)
		{
			Game.IsMouseVisible = true;
			mIdxSel = null;
			base.Reveal (gameTime);
		}

		private int? CalcIdxFromPoint(Point argPoint)
		{
			if (argPoint.X >= mPositionIni.X && argPoint.Y>=mPositionIni.Y) {
				var pDiff = new Point ((argPoint.X - mPositionIni.X) / mMaxSizeItem.X, (argPoint.Y - mPositionIni.Y) / mMaxSizeItem.Y);

				if (pDiff.X <= mMaxItems.X && pDiff.Y <= mMaxItems.Y) {
					var pIdx =mIdx0 + mMaxItems.Y * pDiff.Y + pDiff.X;

					if (pIdx<mItemsAct.Length)
						return pIdx;
				}
			}

			return null;
		}
	}
}

