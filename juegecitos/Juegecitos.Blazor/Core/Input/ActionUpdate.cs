using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juegecitos.Blazor.Core.Input
{
    public class ActionUpdate
    {
        public virtual bool Update(InputSystem argInput, Action argAction)
        {
            if (!IsOk(argInput))
                return false;

            AsignValue(argAction);

            return true;
        }
        protected virtual bool IsOk(InputSystem argInput) => false;
        protected virtual void AsignValue(Action argAction) { }
    }
}
