using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace Juegecitos.Blazor.Core.Input
{
    public class Action
    {
        public readonly static Action None = new Action();

        public Action()
        {
            Reset();
        }

        public Action(params ActionUpdate[] argUpdates) : this()
        {
            Updates.AddRange(argUpdates);
        }


        public Vector2 Vector2 { get; set; }
        public List<ActionUpdate> Updates { get; } = new List<ActionUpdate>();

        public void Reset()
        {
            Vector2 = Vector2.Zero;
        }

        internal bool Update(InputSystem argInput)
        {
            Reset();

            foreach (var pUpdate in Updates)
                if (pUpdate.Update(argInput, this))
                    return true;

            return false;
        }
    }
}
