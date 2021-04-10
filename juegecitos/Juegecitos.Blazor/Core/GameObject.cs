using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Juegecitos.Blazor.Core.Components;

namespace Juegecitos.Blazor.Core
{
    public class GameObject : IUpdate, IRender
    {
        private ComponentsCollection mComponents = new ComponentsCollection();

        public Game Game { get; }

        public GameObject(Game argGame) => Game = argGame;

        public T AddComponent<T>(T argComponent) where T : Component
        {
            argComponent.Owner = this;
            mComponents.Add(argComponent);

            return argComponent;
        }

        public void AddComponents(params Component[] argComponens)
        {
            foreach (var pComponent in argComponens)
                AddComponent(pComponent);
        }

        public T GetComponent<T>() where T : IComponent => mComponents.GetComponent<T>();

        public virtual void Render(GameTime argTime) => mComponents.Render(argTime);

        public virtual void Update(GameTime argTime) => mComponents.Update(argTime);
    }
}
