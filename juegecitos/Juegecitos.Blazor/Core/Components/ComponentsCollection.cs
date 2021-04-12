using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juegecitos.Blazor.Core.Components
{
    public delegate void ComponentsCollectionChange(ComponentsCollection argComps);
    public class ComponentsCollection : IUpdate, IRender, ICollection<IComponent>
    {
        private Dictionary<Type, IComponent> mComponents = new Dictionary<Type, IComponent>();
        private List<IComponentUpdate> mComponentsUpdates = new List<IComponentUpdate>();
        private List<IComponentRender> mComponentsRenders = new List<IComponentRender>();

        public event ComponentsCollectionChange CollectionChange;

        public int Count => mComponents.Count;
        public bool IsReadOnly => false;

        public T GetComponent<T>() where T : IComponent
        {
            if (mComponents.TryGetValue(typeof(T), out IComponent pComponent2))
                if (pComponent2 is T pComponent)
                    return pComponent;

            return default(T);
        }

        public bool Add(IComponent argComponent)
        {
            if (Contains(argComponent))
                return false;

            argComponent.Initialize();
            mComponents.Add(argComponent.GetType(), argComponent);
            if (argComponent.Enabled)
            {
                if (argComponent is IComponentUpdate pUpdate)
                    mComponentsUpdates.Add(pUpdate);
                if (argComponent.Enabled && argComponent is IComponentRender pRender)
                    mComponentsRenders.Add(pRender);
            }
            CollectionChange?.Invoke(this);

            argComponent.EnabledChange -= Component_EnabledChange;
            argComponent.EnabledChange += Component_EnabledChange;

            return true;
        }

        void ICollection<IComponent>.Add(IComponent argComponent) => Add(argComponent);

        public void Clear()
        {
            foreach (var pComponent in this)
                pComponent.EnabledChange -= Component_EnabledChange;
            mComponents.Clear();
            mComponentsUpdates.Clear();
            mComponentsRenders.Clear();
            CollectionChange?.Invoke(this);
        }

        public bool Contains(IComponent item) => mComponents.ContainsKey(item.GetType());

        public void CopyTo(IComponent[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<IComponent> GetEnumerator() => mComponents.Values.GetEnumerator();

        public bool Remove(IComponent item)
        {
            if (!mComponents.Remove(item.GetType()))
                return false;
            if (item.Enabled)
            {
                if (item is IComponentUpdate pUpdate)
                    mComponentsUpdates.Remove(pUpdate);
                if (item is IComponentRender pRender)
                    mComponentsRenders.Remove(pRender);
            }
            CollectionChange?.Invoke(this);
            item.EnabledChange -= Component_EnabledChange;

            return true;
        }

        public void Render(GameTime argTime) => mComponentsRenders.ForEach(o => o.Render(argTime));

        public void Update(GameTime argTime) => mComponentsUpdates.ForEach(o => o.Update(argTime));

        public bool IsUpdater => mComponentsUpdates.Count > 0;
        public bool IsRender => mComponentsRenders.Count > 0;

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        private void Component_EnabledChange(IComponent argComponent, bool argEnabledAnt, bool argEnabledAct)
        {
            if (argEnabledAnt && !argEnabledAct)
            {
                if (argComponent is IComponentUpdate pUpdate)
                    mComponentsUpdates.Remove(pUpdate);
                if (argComponent is IComponentRender pRender)
                    mComponentsRenders.Remove(pRender);
            }
            else if (!argEnabledAnt && argEnabledAct)
            {
                if (argComponent is IComponentUpdate pUpdate)
                    mComponentsUpdates.Add(pUpdate);
                if (argComponent is IComponentRender pRender)
                    mComponentsRenders.Add(pRender);
            }
        }
    }
}
