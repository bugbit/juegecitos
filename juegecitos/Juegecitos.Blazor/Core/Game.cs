using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juegecitos.Blazor.Core
{
    public class Game : IInitialize
    {
        private Scene mActiveScene;

        public IHost Host { get; private set; }
        public Scene ActiveScene
        {
            get => mActiveScene;
            set
            {
                mActiveScene = value;
                Host.SetLoop(mActiveScene);
            }
        }

        public PresentationParameters PresentationParameters { get; } = new PresentationParameters();

        public void AsignHost(IHost argHost) => Host = argHost;

        public virtual void Initialize() { }
        public virtual void UnLoad() { }
    }
}
