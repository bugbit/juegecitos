using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juegecitos.Blazor.Core
{
    public interface ILoad
    {
        bool IsLoaded { get; }
        void Load();
        void UnLoad();
    }
}
