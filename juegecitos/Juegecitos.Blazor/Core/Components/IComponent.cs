﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juegecitos.Blazor.Core.Components
{
    public interface IComponent : IInitialize
    {
        GameObject Owner { get; }
    }
}
