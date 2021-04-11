using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace Juegecitos.Blazor.Core.Components
{
    public class Transform2d : Component2d
    {
        public Vector2 Position { get; set; } = Vector2.Zero;
        public Vector2 Direction { get; set; } = Vector2.One;
        public Vector2 Scale { get; set; } = Vector2.One;
    }
}
