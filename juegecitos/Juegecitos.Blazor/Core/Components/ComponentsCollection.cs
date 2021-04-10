using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juegecitos.Blazor.Core.Components
{
    public class ComponentsCollection : IUpdate, IRender, ICollection<IComponent>
    {
        private Dictionary<Type, IComponent> mComponents = new Dictionary<Type, IComponent>();
        private List<IComponentUpdate> mComponentsUpdates = new List<IComponentUpdate>();
        private List<IComponentRender> mComponentsRenders = new List<IComponentRender>();

        public int Count => mComponents.Count;

        public bool IsReadOnly => false;

        public T GetComponent<T>() where T : IComponent
        {
            if (mComponents.TryGetValue(typeof(T), out IComponent pComponent2))
                if (pComponent2 is T pComponent)
                    return pComponent;

            return default(T);
        }

        public void Add(IComponent argComponent)
        {
            argComponent.Initialize();
            mComponents.Add(argComponent.GetType(), argComponent);
            if (argComponent is IComponentUpdate pUpdate)
                mComponentsUpdates.Add(pUpdate);
            if (argComponent is IComponentRender pRender)
                mComponentsRenders.Add(pRender);
        }

        public void Clear()
        {
            mComponents.Clear();
            mComponentsUpdates.Clear();
            mComponentsRenders.Clear();
        }

        public bool Contains(IComponent item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(IComponent[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<IComponent> GetEnumerator() => mComponents.Values;

        public bool Remove(IComponent item)
        {
            if (!mComponents.Remove(item.GetType()))
                return false;
            if (item is IComponentUpdate pUpdate)
                mComponentsUpdates.Remove(pUpdate);
            if (item is IComponentRender pRender)
                mComponentsRenders.Remove(pRender);

            return true;
        }

        public void Render(GameTime argTime) => mComponentsRenders.ForEach(o => o.Render(argTime));

        public void Update(GameTime argTime) => mComponentsUpdates.ForEach(o => o.Update(argTime));

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
