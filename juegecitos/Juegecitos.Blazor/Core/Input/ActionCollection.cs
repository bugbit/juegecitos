using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace Juegecitos.Blazor.Core.Input
{
    public class ActionCollection : Dictionary<string, Action>
    {
        public Action GetAction(string argName) => (TryGetValue(argName, out Action pAction)) ? pAction : Action.None;
        public Vector2 GetAxis(string argName) => GetAction(argName).Vector2;

        internal void Update(InputSystem argInput)
        {
            foreach (var pAction in this.Values)
                pAction.Update(argInput);
        }
    }
}
