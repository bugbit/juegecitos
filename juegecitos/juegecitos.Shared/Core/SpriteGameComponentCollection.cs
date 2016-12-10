using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace juegecitos.Shared.Core
{
	public sealed class SpriteGameComponentCollection : Collection<ISpriteGameComponent>
	{
		private ISpriteGameComponent[] mGameComponentsEnabled=null;
		private ISpriteGameComponent[] mGameComponentsVisible=null;

		public event EventHandler<SpriteGameComponentCollectionEventArgs> ComponentAdded;
		public event EventHandler<SpriteGameComponentCollectionEventArgs> ComponentRemoved;

		public void Update(GameTime gameTime) 
		{
			if (mGameComponentsEnabled == null) {
				var pList = new List<ISpriteGameComponent> ();

				foreach (var pComponent in this)
					if (pComponent.Enabled) {
						pList.Add (pComponent);
						pComponent.Update (gameTime);
					}
				mGameComponentsEnabled = pList.ToArray ();
			} else
				foreach (var pComponent in mGameComponentsEnabled)
					pComponent.Update (gameTime);
		}

		public void Draw(SpriteBatch argSB,GameTime gameTime)
		{
			if (mGameComponentsVisible == null) {
				var pList = new List<ISpriteGameComponent> ();

				foreach (var pComponent in this)
					if (pComponent.Visible) {
						pList.Add (pComponent);
						pComponent.Draw(argSB,gameTime);
					}
				mGameComponentsVisible = pList.ToArray ();
			} else
				foreach (var pComponent in mGameComponentsVisible)
					pComponent.Draw(argSB,gameTime);
		}

		protected override void ClearItems()
		{
			for (int i = 0; i < base.Count; i++)
			{
				this.OnComponentRemoved(new SpriteGameComponentCollectionEventArgs(base[i]));
			}
			base.ClearItems();
			ClearCacheEnabled ();
			ClearCacheVisible ();
		}

		protected override void InsertItem(int argIndex, ISpriteGameComponent argItem)
		{
			if (base.IndexOf(argItem) != -1)
			{
				throw new ArgumentException("Cannot Add Same Component Multiple Times");
			}
			base.InsertItem(argIndex, argItem);
			if (argItem != null)
			{
				this.OnComponentAdded(new SpriteGameComponentCollectionEventArgs(argItem));
			}
		}

		private void OnComponentAdded(SpriteGameComponentCollectionEventArgs e)
		{
			var pComponent = e.SpriteGameComponent;

			pComponent.EnabledChanged += SpriteGameComponent_EnabledChanged;
			pComponent.VisibleChanged += SpriteGameComponent_EnabledChanged;
			if (pComponent.Enabled)
				ClearCacheEnabled ();
			if (pComponent.Visible)
				ClearCacheVisible ();
			if (this.ComponentAdded != null)
			{
				this.ComponentAdded(this, e);
			}
		}

		private void OnComponentRemoved(SpriteGameComponentCollectionEventArgs e)
		{

			var pComponent = e.SpriteGameComponent;

			pComponent.EnabledChanged -= SpriteGameComponent_EnabledChanged;
			pComponent.VisibleChanged -= SpriteGameComponent_EnabledChanged;
			if (this.ComponentRemoved != null)
			{
				this.ComponentRemoved(this, e);
			}
		}

		protected override void RemoveItem(int argIndex)
		{
			ISpriteGameComponent pComponent = base[argIndex];

			base.RemoveItem(argIndex);
			if (pComponent != null)
			{
				this.OnComponentRemoved(new SpriteGameComponentCollectionEventArgs(pComponent));
			}
		}

		protected override void SetItem(int argIndex, ISpriteGameComponent argItem)
		{
			throw new NotSupportedException();
		}

		private void ClearCacheEnabled()
		{
			mGameComponentsEnabled = null;
		}

		private void ClearCacheVisible()
		{
			mGameComponentsVisible = null;
		}

		private void SpriteGameComponent_EnabledChanged(object sender,EventArgs e)
		{
			ClearCacheEnabled ();
		}

		private void SpriteGameComponent_VisibleChanged(object sender,EventArgs e)
		{
			ClearCacheVisible ();
		}
	}
}

