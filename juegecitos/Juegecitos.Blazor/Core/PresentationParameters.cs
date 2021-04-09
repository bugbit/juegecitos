using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juegecitos.Blazor.Core
{
    public class PresentationParameters
    {
        public string BackColor { get; set; } = "black";
        public int Width { get; set; } = 800;
        public int Height { get; set; } = 600;
        public string CanvasContext { get; set; } = "2d";
    }
}
