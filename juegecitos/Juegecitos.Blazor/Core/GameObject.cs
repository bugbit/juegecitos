using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Juegecitos.Blazor.Core.Components;

namespace Juegecitos.Blazor.Core
{
    public delegate void GameObjectChangePropCol(GameObject argGameObject);

    public class GameObject : IInitialize, IUpdate, IRender
    {
        private ComponentsCollection mComponents = new ComponentsCollection();
        private bool mVisible;
        private int mOrden;
        private bool mIsUpdaterChangePropCol;
        private bool mIsRenderChangePropCol;

        public Scene Scene { get; }
        public event GameObjectChangePropCol ChangePropCol;
        public bool Visible
        {
            get => mVisible;
            set
            {
                if (mVisible != value)
                    ChangePropCol?.Invoke(this);
                mVisible = value;
            }
        }
        public int Orden
        {
            get => mOrden;
            set
            {
                if (mOrden != value)
                    ChangePropCol?.Invoke(this);
                mOrden = value;
            }
        }

        public GameObject(Scene argScene, params Component[] argComponens)
        {
            Scene = argScene;
            AddComponents(argComponens);
            AsignCollectionChange();
        }

        private void AsignCollectionChange()
        {
            mIsUpdaterChangePropCol = IsUpdater;
            mIsRenderChangePropCol = IsRender;
            mComponents.CollectionChange += Components_CollectionChange;
        }

        private void Components_CollectionChange(ComponentsCollection argComps)
        {
            var pIsUpdater = IsUpdater;
            var pIsRender = IsRender;

            if (mIsUpdaterChangePropCol != pIsUpdater || mIsRenderChangePropCol != pIsRender)
            {
                ChangePropCol?.Invoke(this);
                mIsUpdaterChangePropCol = pIsUpdater;
                mIsRenderChangePropCol = pIsRender;
            }
        }

        public virtual void Initialize() { }

        public T AddComponent<T>(T argComponent) where T : Component
        {
            var pIsUpdater = IsUpdater;
            var pIsRender = IsRender;

            argComponent.Owner = this;
            mComponents.Add(argComponent);

            if (pIsRender != IsRender)
                ChangePropCol?.Invoke(this);
            if (pIsRender != IsRender)
                ChangePropCol?.Invoke(this);

            return argComponent;
        }

        public T AddComponent<T>() where T : Component, new() => AddComponent(new T());

        public void AddComponents(params Component[] argComponens)
        {
            foreach (var pComponent in argComponens)
                AddComponent(pComponent);
        }

        public T GetComponent<T>() where T : IComponent => mComponents.GetComponent<T>();

        public virtual void Render(GameTime argTime) => mComponents.Render(argTime);

        public virtual void Update(GameTime argTime) => mComponents.Update(argTime);
        public bool IsUpdater => mComponents.IsUpdater;
        public bool IsRender => mComponents.IsRender;
    }
}
