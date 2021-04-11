using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Juegecitos.Blazor.Core.Components;

namespace Juegecitos.Blazor.Core
{
    public class GameObject : IInitialize, IUpdate, IRender
    {
        private ComponentsCollection mComponents = new ComponentsCollection();

        public Scene Scene { get; }

        public GameObject(Scene argScene, params Component[] argComponens)
        {
            Scene = argScene;
            AddComponents(argComponens);
        }

        public virtual void Initialize() { }

        public T AddComponent<T>(T argComponent) where T : Component
        {
            argComponent.Owner = this;
            mComponents.Add(argComponent);

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
