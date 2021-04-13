using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace Juegecitos.Blazor.Core
{
    // https://riptutorial.com/html5-canvas/example/19666/a-transformation-matrix-to-track-translated--rotated---scaled-shape-s-
    // https://www.w3resource.com/html5-canvas/html5-canvas-matrix-transforms.php
    public class Transform2d
    {
        public Vector2 Position { get; set; } = Vector2.Zero;
        public Vector2 Direction { get; set; } = Vector2.One;
        public Vector2 Scale { get; set; } = Vector2.One;
    }
}
