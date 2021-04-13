using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juegecitos.Blazor.Core
{
    public class Game : IInitialize
    {
        public IHost Host { get; private set; }
        public Scene ActiveScene { get; private set; }

        public PresentationParameters PresentationParameters { get; } = new PresentationParameters();

        internal void AsignHost(IHost argHost) => Host = argHost;
        internal void AsignActiveScene(Scene argScene) => ActiveScene = argScene;

        public virtual void Initialize() { }
        public virtual void UnLoad() { }
    }
}
