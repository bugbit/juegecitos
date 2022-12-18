using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juegecitos.Blazor.Core
{
    public interface IUpdate
    {
        void Update(GameTime argTime);
    }
}
