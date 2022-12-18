using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juegecitos.Blazor.Core
{
    public class GameObject : IInitialize //, IUpdate, IRender
    {

        public Scene Scene { get; }

        public bool IsUpdater => this is IUpdate;
        public bool IsRender => this is IRender;

        public GameObject(Scene argScene)
        {
            Scene = argScene;
        }

        public virtual void Initialize() { }

        //public virtual void Render(GameTime argTime) { }

        //public virtual void Update(GameTime argTime) { }
    }
}
