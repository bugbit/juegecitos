using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juegecitos.Blazor.Core.Components
{
    public class Component : IComponent
    {
        private bool mEnabled = true;

        public GameObject Owner { get; set; }
        public bool Enabled
        {
            get => mEnabled;
            set
            {
                if (mEnabled != value)
                    EnabledChange?.Invoke(this, mEnabled, value);
                mEnabled = value;
            }
        }

        public event ComponentPropEnabledChange EnabledChange;

        public virtual void Initialize() { }
    }
}
