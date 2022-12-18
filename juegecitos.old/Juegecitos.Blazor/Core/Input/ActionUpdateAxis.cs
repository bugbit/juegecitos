using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace Juegecitos.Blazor.Core.Input
{
    public class ActionUpdateAxis : ActionUpdate
    {
        public Vector2 Axis { get; set; }

        protected override void AsignValue(Action argAction)
        {
            argAction.Vector2 = Axis;
        }
    }
}
