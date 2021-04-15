using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juegecitos.Blazor.Core
{
    public class Game : IInitialize, ILoad
    {
        public float TotalTime { get; internal set; } = 0;
        public IHost Host { get; internal set; }
        public Scene ActiveScene { get; internal set; }
        public bool IsLoaded { get; private set; }
        public string BackColor { get; internal set; }
        public int Width { get; internal set; }
        public int Height { get; internal set; }
        public string CanvasContext { get; internal set; }

        public PresentationParameters PresentationParameters { get; } = new PresentationParameters();

        
        public virtual void Initialize() { }
        public void Load()
        {
            Initialize();
            IsLoaded = true;
        }
        public void UnLoad() { }
    }
}
